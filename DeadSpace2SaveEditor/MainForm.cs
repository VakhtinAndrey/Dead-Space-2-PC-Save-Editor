using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DeadSpace2SaveEditor.Code;
using DeadSpace2SaveEditor.Models;
using DeadSpace2SaveEditor.Properties;

namespace DeadSpace2SaveEditor
{
    public partial class MainForm : Form
    {
        #region Properties
        private string _saveFilePath;

        public string SaveFilePath
        {
            get { return _saveFilePath; }
            set
            {
                _saveFilePath = value;
                tbFileName.Text = value;
                tbFileName.SelectionStart = value.Length;
                tbFileName.SelectionLength = 0;
            }
        }

        private FileMetadata _metadata;
        public FileMetadata Metadata {
            get { return _metadata; }
            set
            {
                _metadata = value;
                if (value != null)
                {
                    lblSlotValue.Text = value.Slot;
                    lblTimePlayedValue.Text = value.GetTimeString();
                    var diff = Enum.Parse(typeof (Difficulty), value.Difficulty);
                    lblDifficultyValue.Text = TranslateResources.ResourceManager.GetString($"{nameof(Difficulty)}_{diff}") ?? diff.ToString();
                    lblChapterValue.Text = value.Chapter;
                    lblRoundValue.Text = value.Round;
                }
                else
                {
                    lblSlotValue.Text = null;
                    lblTimePlayedValue.Text = null;
                    lblDifficultyValue.Text = null;
                    lblChapterValue.Text = null;
                    lblRoundValue.Text = null;
                }
            }
        }

        private MemoryStream DataStream { get; set; }

        private MC02Header MC02Header { get; set; }

        private InventoryData OriginalInventoryData { get; set; }
        private InventoryData _newInventoryData;
        private InventoryData NewInventoryData
        {
            get { return _newInventoryData; }
            set
            {
                _newInventoryData = value;
                nudCredits.Value = value?.Credits ?? 0;
            }
        }

        private SafeData OriginalSafeData { get; set; }
        private SafeData NewSafeData { get; set; }

        private ShopData OriginalShopData { get; set; }
        private ShopData NewShopData { get; set; }

        private WeaponsData OriginalWeaponsData { get; set; }
        private WeaponsData NewWeaponsData { get; set; }

        private MiscData _miscData;

        private MiscData MiscData
        {
            get
            {
                return _miscData;
            }
            set
            {
                _miscData = value;
                cbInfiniteAmmo.Checked = value != null && value.Flags[(byte) Flags.InfiniteAmmo] != 0;
                cbInfiniteStasis.Checked = value?.Stasis > 100000000;
                nudNodes.Value = value?.Nodes ?? 0;
                if (value != null)
                {
                    if (!SuitsDataSource.ContainsKey(value.ActiveSuit))
                    {
                        SuitsDataSource.Add(value.ActiveSuit, value.ActiveSuit.Title);
                        cbActiveSuit.DataSource = new BindingSource(SuitsDataSource, null);
                    }
                    cbActiveSuit.SelectedValue = value.ActiveSuit;
                }
            }
        }

        private Dictionary<ItemDescriptor, string> SuitsDataSource;
        #endregion

        public MainForm()
        {
            InitializeComponent();

            this.Text = AppHelper.GetApplicationName();

            SuitsDataSource = MagicStuff.ItemDescriptors
                .Where(d => d.Type == ItemType.Suit)
                .OrderBy(d => d.Title)
                .ToDictionary(d => d, d => d.Title);
            cbActiveSuit.DisplayMember = "Value";
            cbActiveSuit.ValueMember = "Key";
            cbActiveSuit.DataSource = new BindingSource(SuitsDataSource, null);

            this.BackgroundImage = Resources.Background1;

            var fontColor1 = Color.FromArgb(0xE5, 0xE5, 0xE5);
            var fontColor2 = Color.PowderBlue;
            var bgColor = Color.FromArgb(96, Color.Black);
            gbFileMetadata.BackColor = Color.Transparent;

            lblSlotValue.Text = string.Empty;
            lblTimePlayedValue.Text = string.Empty;
            lblDifficultyValue.Text = string.Empty;
            lblChapterValue.Text = string.Empty;
            lblRoundValue.Text = string.Empty;

            msMainMenu.BackColor = Color.FromArgb(196, SystemColors.Control);

            tbFileName.BackColor = fontColor1;
            nudCredits.BackColor = fontColor1;
            nudNodes.BackColor = fontColor1;

            foreach (var control in Controls.Cast<Control>().Where(c => c is Label || c is CheckBox))
            {
                control.BackColor = bgColor;
                control.ForeColor = fontColor1;
            }
            foreach (var control in gbFileMetadata.Controls.Cast<Control>().Where(c => c is Label))
            {
                control.BackColor = bgColor;
                control.ForeColor = fontColor2;
            }
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            var files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                SaveFilePath = files[0];
                LoadFileData();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdSaveFile.ShowDialog() != DialogResult.OK)
                return;

            SaveFilePath = ofdSaveFile.FileName;
            LoadFileData();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataStream == null || MC02Header == null || SaveFilePath == null)
                return;

            ApplyNewValues();
            ChecksumsStuff.FixChecksums(DataStream, MC02Header);
            SaveFileData();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveFilePath != null)
                LoadFileData();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(string.Format("{1}{0}{0}by Andrey Vakhtin (c) 2016{0}{0}Contact me:{0} - https://github.com/VakhtinAndrey{0} - smile.voronezh@gmail.com", Environment.NewLine, AppHelper.GetApplicationName()));
            new AboutForm().ShowDialog();
        }

        private void nudCredits_ValueChanged(object sender, EventArgs e)
        {
            if (NewInventoryData != null)
                NewInventoryData.Credits = (uint) nudCredits.Value;
        }

        private void btnEditItems_Click(object sender, EventArgs e)
        {
            var form = new ItemsForm(NewInventoryData, NewSafeData, NewShopData, NewWeaponsData);
            if (form.ShowDialog() == DialogResult.OK)
            {
                NewInventoryData = form.InventoryData;
                NewSafeData = form.SafeData;
                NewShopData = form.ShopData;
                NewWeaponsData = form.WeaponsData;
            }
        }

        private void LoadFileData()
        {
            Cursor = Cursors.WaitCursor;

            Metadata = null;
            DataStream = null;
            MC02Header = null;
            OriginalInventoryData = null;
            NewInventoryData = null;
            OriginalSafeData = null;
            NewSafeData = null;
            OriginalShopData = null;
            NewShopData = null;
            OriginalWeaponsData = null;
            NewWeaponsData = null;
            MiscData = null;

            try
            {
                using (var fs = File.OpenRead(SaveFilePath))
                {
                    DataStream = new MemoryStream();
                    fs.CopyTo(DataStream);
                }

                if (!ValidateSaveFile())
                    return;

                DataStream.Seek(0x2034, SeekOrigin.Begin);
                var meta = DataStream.ReadUnicodeString();
                var re = new Regex(@"^\D*(\d{1,2})\D*(\d{1,2})\D*(\d{1,2})\D*(\d{1,2})\D*(\d{1,2})\D*(\d{1,2})\D*(\d{1,2})\D*$");
                var match = re.Match(meta);
                if (match.Success)
                {
                    Metadata = new FileMetadata
                    {
                        Slot = match.Groups[1].Value,
                        HoursPlayed = match.Groups[2].Value,
                        MinutesPlayed = match.Groups[3].Value,
                        SecondsPlayed = match.Groups[4].Value,
                        Difficulty = match.Groups[5].Value,
                        Chapter = match.Groups[6].Value,
                        Round = match.Groups[7].Value
                    };
                }

                OriginalInventoryData = new InventoryData(DataStream);
                NewInventoryData = new InventoryData
                {
                    Unk1 = OriginalInventoryData.Unk1,
                    Credits = OriginalInventoryData.Credits,
                    Items = new List<InventoryEntity>(OriginalInventoryData.Items)
                };
                OriginalSafeData = new SafeData(DataStream);
                NewSafeData = new SafeData
                {
                    SafeCapacity = OriginalSafeData.SafeCapacity,
                    Unk1 = OriginalSafeData.Unk1,
                    Items = new List<SafeEntity>(OriginalSafeData.Items)
                };
                OriginalShopData = new ShopData(DataStream);
                NewShopData = new ShopData
                {
                    Unk1 = OriginalShopData.Unk1,
                    Items = new List<ShopEntity>(OriginalShopData.Items)
                };
                OriginalWeaponsData = new WeaponsData(DataStream);
                NewWeaponsData = new WeaponsData
                {
                    ActiveSlots = OriginalWeaponsData.ActiveSlots,
                    Unk1 = OriginalWeaponsData.Unk1,
                    Items = new List<WeaponEntity>(OriginalWeaponsData.Items)
                };
                MiscData = new MiscData(DataStream);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry, an error occurred while reading from file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private bool ValidateSaveFile()
        {
            DataStream.Seek(0x0, SeekOrigin.Begin);
            var magic = DataStream.ReadInt32();
            if (magic != 1213024082) // RGMH
            {
                MessageBox.Show(
                    $"Invalid DS2 PC magic at 0x0. Should be 'RGMH', found '{Encoding.ASCII.GetString(BitConverter.GetBytes(magic))}'.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            DataStream.Seek(0x28, SeekOrigin.Begin);
            var sig = DataStream.ReadUnicodeString();
            if (sig != "Dead Space 2")
            {
                MessageBox.Show($"Invalid DS2 PC signature at 0x28. Should be 'Dead Space 2', found '{sig}'.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            DataStream.Seek(0x2834, SeekOrigin.Begin);
            MC02Header = new MC02Header
            {
                Magic = DataStream.ReadUInt32(),
                TotalLength = DataStream.ReadUInt32(),
                Chunk0Length = DataStream.ReadUInt32(),
                Chunk1Length = DataStream.ReadUInt32(),
                Checksum0 = DataStream.ReadUInt32(),
                Checksum1 = DataStream.ReadUInt32(),
                Checksum2 = DataStream.ReadUInt32(),
            };

            if (MC02Header.Magic != 1296248882) // 20CM
            {
                MessageBox.Show(
                    $"Invalid MC02 magic at 0x2834. Should be '20CM', found '{Encoding.ASCII.GetString(BitConverter.GetBytes(MC02Header.Magic))}'.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (MC02Header.TotalLength != MC02Header.Chunk0Length + MC02Header.Chunk1Length + 0x1C)
            {
                MessageBox.Show("Size mismatch", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ApplyNewValues()
        {
            if (cbInfiniteStasis.Checked)
            {
                MiscData.Stasis = float.MaxValue;
            }
            MiscData.Flags[(byte)Flags.InfiniteAmmo] = cbInfiniteAmmo.Checked ? (byte)1 : (byte)0;
            MiscData.Nodes = (uint)nudNodes.Value;
            MiscData.ActiveSuit = (ItemDescriptor) cbActiveSuit.SelectedValue;
            NewInventoryData.Credits = (uint)nudCredits.Value;
            
            NewInventoryData.WriteData(DataStream);
            NewWeaponsData.WriteData(DataStream);
            NewSafeData.WriteData(DataStream);
            NewShopData.WriteData(DataStream);
            MiscData.WriteData(DataStream);

            #region Fix size bytes
            var origSize = (uint)(OriginalInventoryData.GetDataSize() + OriginalSafeData.GetDataSize() + OriginalShopData.GetDataSize() + OriginalWeaponsData.GetDataSize());
            var newSize = (uint)(NewInventoryData.GetDataSize() + NewSafeData.GetDataSize() + NewShopData.GetDataSize() + NewWeaponsData.GetDataSize());

            DataStream.Seek(0x28BC, SeekOrigin.Begin);
            var totalDataChunkSize = DataStream.ReadUInt32();

            var itemsBlockPos = DataStream.SearchForBytePattern(MagicStuff.ItemBlockMagic) + MagicStuff.ItemBlockMagic.Length;
            DataStream.Seek(itemsBlockPos, SeekOrigin.Begin);
            var itemsBlockSize = DataStream.ReadUInt32();

            // 1st size to fix
            DataStream.Seek(0x28BC, SeekOrigin.Begin);
            DataStream.WriteUInt32(totalDataChunkSize - origSize + newSize);

            // 2nd size to fix
            DataStream.Seek(itemsBlockPos, SeekOrigin.Begin);
            DataStream.WriteUInt32(itemsBlockSize - origSize + newSize);
            #endregion

            OriginalInventoryData = new InventoryData
            {
                Unk1 = NewInventoryData.Unk1,
                Credits = NewInventoryData.Credits,
                Items = NewInventoryData.Items
            };
            OriginalSafeData = new SafeData
            {
                SafeCapacity = NewSafeData.SafeCapacity,
                Unk1 = NewSafeData.Unk1,
                Items = NewSafeData.Items
            };
            OriginalShopData = new ShopData
            {
                Unk1 = NewShopData.Unk1,
                Items = NewShopData.Items
            };
            OriginalWeaponsData = new WeaponsData
            {
                ActiveSlots = NewWeaponsData.ActiveSlots,
                Unk1 = NewWeaponsData.Unk1,
                Items = NewWeaponsData.Items
            };
        }

        private void SaveFileData()
        {
            if (MessageBox.Show($"!!! WARNING !!!{Environment.NewLine}Remember to make a backup!{Environment.NewLine}{Environment.NewLine}Overwrite file?{Environment.NewLine}{SaveFilePath}", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            Cursor = Cursors.WaitCursor;

            try
            {
                using (var fs = File.Create(SaveFilePath))
                {
                    DataStream.WriteTo(fs);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry, an error occurred while writing to file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }

        }
    }
}
