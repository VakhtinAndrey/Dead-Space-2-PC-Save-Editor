namespace DeadSpace2SaveEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separator1ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdSaveFile = new System.Windows.Forms.OpenFileDialog();
            this.gbFileMetadata = new System.Windows.Forms.GroupBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.lblRoundValue = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.lblChapterValue = new System.Windows.Forms.Label();
            this.lblChapter = new System.Windows.Forms.Label();
            this.lblDifficultyValue = new System.Windows.Forms.Label();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.lblTimePlayedValue = new System.Windows.Forms.Label();
            this.lblTimePlayed = new System.Windows.Forms.Label();
            this.lblSlotValue = new System.Windows.Forms.Label();
            this.lblSlot = new System.Windows.Forms.Label();
            this.btnEditItems = new System.Windows.Forms.Button();
            this.nudCredits = new System.Windows.Forms.NumericUpDown();
            this.lblCredits = new System.Windows.Forms.Label();
            this.lblNodes = new System.Windows.Forms.Label();
            this.nudNodes = new System.Windows.Forms.NumericUpDown();
            this.cbInfiniteStasis = new System.Windows.Forms.CheckBox();
            this.cbInfiniteAmmo = new System.Windows.Forms.CheckBox();
            this.cbActiveSuit = new System.Windows.Forms.ComboBox();
            this.lblActiveSuit = new System.Windows.Forms.Label();
            this.msMainMenu.SuspendLayout();
            this.gbFileMetadata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCredits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNodes)).BeginInit();
            this.SuspendLayout();
            // 
            // msMainMenu
            // 
            this.msMainMenu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.reloadToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(425, 27);
            this.msMainMenu.TabIndex = 0;
            this.msMainMenu.Text = "mcMainMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.separator1ToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 23);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // separator1ToolStripMenuItem
            // 
            this.separator1ToolStripMenuItem.Name = "separator1ToolStripMenuItem";
            this.separator1ToolStripMenuItem.Size = new System.Drawing.Size(161, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(62, 23);
            this.reloadToolStripMenuItem.Text = "&Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(59, 23);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // ofdSaveFile
            // 
            this.ofdSaveFile.Filter = "Dead Space 2 save|*.deadspace2saved";
            // 
            // gbFileMetadata
            // 
            this.gbFileMetadata.Controls.Add(this.lblFileName);
            this.gbFileMetadata.Controls.Add(this.tbFileName);
            this.gbFileMetadata.Controls.Add(this.lblRoundValue);
            this.gbFileMetadata.Controls.Add(this.lblRound);
            this.gbFileMetadata.Controls.Add(this.lblChapterValue);
            this.gbFileMetadata.Controls.Add(this.lblChapter);
            this.gbFileMetadata.Controls.Add(this.lblDifficultyValue);
            this.gbFileMetadata.Controls.Add(this.lblDifficulty);
            this.gbFileMetadata.Controls.Add(this.lblTimePlayedValue);
            this.gbFileMetadata.Controls.Add(this.lblTimePlayed);
            this.gbFileMetadata.Controls.Add(this.lblSlotValue);
            this.gbFileMetadata.Controls.Add(this.lblSlot);
            this.gbFileMetadata.Location = new System.Drawing.Point(12, 36);
            this.gbFileMetadata.Name = "gbFileMetadata";
            this.gbFileMetadata.Size = new System.Drawing.Size(401, 155);
            this.gbFileMetadata.TabIndex = 10;
            this.gbFileMetadata.TabStop = false;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFileName.Location = new System.Drawing.Point(6, 22);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(82, 18);
            this.lblFileName.TabIndex = 0;
            this.lblFileName.Text = "Save File:";
            // 
            // tbFileName
            // 
            this.tbFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFileName.Location = new System.Drawing.Point(94, 19);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.ReadOnly = true;
            this.tbFileName.Size = new System.Drawing.Size(292, 24);
            this.tbFileName.TabIndex = 1;
            // 
            // lblRoundValue
            // 
            this.lblRoundValue.AutoSize = true;
            this.lblRoundValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRoundValue.Location = new System.Drawing.Point(254, 86);
            this.lblRoundValue.Name = "lblRoundValue";
            this.lblRoundValue.Size = new System.Drawing.Size(13, 18);
            this.lblRoundValue.TabIndex = 11;
            this.lblRoundValue.Text = "-";
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRound.Location = new System.Drawing.Point(186, 86);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(62, 18);
            this.lblRound.TabIndex = 10;
            this.lblRound.Text = "Round:";
            // 
            // lblChapterValue
            // 
            this.lblChapterValue.AutoSize = true;
            this.lblChapterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChapterValue.Location = new System.Drawing.Point(254, 55);
            this.lblChapterValue.Name = "lblChapterValue";
            this.lblChapterValue.Size = new System.Drawing.Size(13, 18);
            this.lblChapterValue.TabIndex = 9;
            this.lblChapterValue.Text = "-";
            // 
            // lblChapter
            // 
            this.lblChapter.AutoSize = true;
            this.lblChapter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChapter.Location = new System.Drawing.Point(176, 55);
            this.lblChapter.Name = "lblChapter";
            this.lblChapter.Size = new System.Drawing.Size(72, 18);
            this.lblChapter.TabIndex = 8;
            this.lblChapter.Text = "Chapter:";
            // 
            // lblDifficultyValue
            // 
            this.lblDifficultyValue.AutoSize = true;
            this.lblDifficultyValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDifficultyValue.Location = new System.Drawing.Point(94, 117);
            this.lblDifficultyValue.Name = "lblDifficultyValue";
            this.lblDifficultyValue.Size = new System.Drawing.Size(13, 18);
            this.lblDifficultyValue.TabIndex = 7;
            this.lblDifficultyValue.Text = "-";
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDifficulty.Location = new System.Drawing.Point(10, 117);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(78, 18);
            this.lblDifficulty.TabIndex = 6;
            this.lblDifficulty.Text = "Difficulty:";
            // 
            // lblTimePlayedValue
            // 
            this.lblTimePlayedValue.AutoSize = true;
            this.lblTimePlayedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTimePlayedValue.Location = new System.Drawing.Point(94, 86);
            this.lblTimePlayedValue.Name = "lblTimePlayedValue";
            this.lblTimePlayedValue.Size = new System.Drawing.Size(13, 18);
            this.lblTimePlayedValue.TabIndex = 5;
            this.lblTimePlayedValue.Text = "-";
            // 
            // lblTimePlayed
            // 
            this.lblTimePlayed.AutoSize = true;
            this.lblTimePlayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTimePlayed.Location = new System.Drawing.Point(25, 86);
            this.lblTimePlayed.Name = "lblTimePlayed";
            this.lblTimePlayed.Size = new System.Drawing.Size(63, 18);
            this.lblTimePlayed.TabIndex = 4;
            this.lblTimePlayed.Text = "Played:";
            // 
            // lblSlotValue
            // 
            this.lblSlotValue.AutoSize = true;
            this.lblSlotValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSlotValue.Location = new System.Drawing.Point(94, 55);
            this.lblSlotValue.Name = "lblSlotValue";
            this.lblSlotValue.Size = new System.Drawing.Size(13, 18);
            this.lblSlotValue.TabIndex = 3;
            this.lblSlotValue.Text = "-";
            // 
            // lblSlot
            // 
            this.lblSlot.AutoSize = true;
            this.lblSlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSlot.Location = new System.Drawing.Point(45, 55);
            this.lblSlot.Name = "lblSlot";
            this.lblSlot.Size = new System.Drawing.Size(43, 18);
            this.lblSlot.TabIndex = 2;
            this.lblSlot.Text = "Slot:";
            // 
            // btnEditItems
            // 
            this.btnEditItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditItems.Location = new System.Drawing.Point(305, 270);
            this.btnEditItems.Name = "btnEditItems";
            this.btnEditItems.Size = new System.Drawing.Size(93, 34);
            this.btnEditItems.TabIndex = 9;
            this.btnEditItems.Text = "Edit Items";
            this.btnEditItems.UseVisualStyleBackColor = true;
            this.btnEditItems.Click += new System.EventHandler(this.btnEditItems_Click);
            // 
            // nudCredits
            // 
            this.nudCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudCredits.Location = new System.Drawing.Point(106, 206);
            this.nudCredits.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudCredits.Name = "nudCredits";
            this.nudCredits.Size = new System.Drawing.Size(100, 24);
            this.nudCredits.TabIndex = 2;
            this.nudCredits.ValueChanged += new System.EventHandler(this.nudCredits_ValueChanged);
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCredits.Location = new System.Drawing.Point(33, 208);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(67, 18);
            this.lblCredits.TabIndex = 1;
            this.lblCredits.Text = "Credits:";
            // 
            // lblNodes
            // 
            this.lblNodes.AutoSize = true;
            this.lblNodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNodes.Location = new System.Drawing.Point(38, 243);
            this.lblNodes.Name = "lblNodes";
            this.lblNodes.Size = new System.Drawing.Size(62, 18);
            this.lblNodes.TabIndex = 3;
            this.lblNodes.Text = "Nodes:";
            // 
            // nudNodes
            // 
            this.nudNodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudNodes.Location = new System.Drawing.Point(106, 241);
            this.nudNodes.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudNodes.Name = "nudNodes";
            this.nudNodes.Size = new System.Drawing.Size(100, 24);
            this.nudNodes.TabIndex = 4;
            // 
            // cbInfiniteStasis
            // 
            this.cbInfiniteStasis.AutoSize = true;
            this.cbInfiniteStasis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbInfiniteStasis.Location = new System.Drawing.Point(270, 207);
            this.cbInfiniteStasis.Name = "cbInfiniteStasis";
            this.cbInfiniteStasis.Size = new System.Drawing.Size(128, 22);
            this.cbInfiniteStasis.TabIndex = 5;
            this.cbInfiniteStasis.Text = "Infinite Stasis";
            this.cbInfiniteStasis.UseVisualStyleBackColor = true;
            // 
            // cbInfiniteAmmo
            // 
            this.cbInfiniteAmmo.AutoSize = true;
            this.cbInfiniteAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbInfiniteAmmo.Location = new System.Drawing.Point(269, 242);
            this.cbInfiniteAmmo.Name = "cbInfiniteAmmo";
            this.cbInfiniteAmmo.Size = new System.Drawing.Size(129, 22);
            this.cbInfiniteAmmo.TabIndex = 6;
            this.cbInfiniteAmmo.Text = "Infinite Ammo";
            this.cbInfiniteAmmo.UseVisualStyleBackColor = true;
            // 
            // cbActiveSuit
            // 
            this.cbActiveSuit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActiveSuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbActiveSuit.FormattingEnabled = true;
            this.cbActiveSuit.Location = new System.Drawing.Point(106, 275);
            this.cbActiveSuit.Name = "cbActiveSuit";
            this.cbActiveSuit.Size = new System.Drawing.Size(176, 26);
            this.cbActiveSuit.TabIndex = 8;
            // 
            // lblActiveSuit
            // 
            this.lblActiveSuit.AutoSize = true;
            this.lblActiveSuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblActiveSuit.Location = new System.Drawing.Point(8, 278);
            this.lblActiveSuit.Name = "lblActiveSuit";
            this.lblActiveSuit.Size = new System.Drawing.Size(92, 18);
            this.lblActiveSuit.TabIndex = 7;
            this.lblActiveSuit.Text = "Active Suit:";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 315);
            this.Controls.Add(this.btnEditItems);
            this.Controls.Add(this.lblActiveSuit);
            this.Controls.Add(this.cbActiveSuit);
            this.Controls.Add(this.cbInfiniteAmmo);
            this.Controls.Add(this.cbInfiniteStasis);
            this.Controls.Add(this.nudNodes);
            this.Controls.Add(this.lblNodes);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.nudCredits);
            this.Controls.Add(this.gbFileMetadata);
            this.Controls.Add(this.msMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMainMenu;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dead Space 2 PC Save Editor";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.gbFileMetadata.ResumeLayout(false);
            this.gbFileMetadata.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCredits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNodes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofdSaveFile;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbFileMetadata;
        private System.Windows.Forms.Label lblRoundValue;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.Label lblChapterValue;
        private System.Windows.Forms.Label lblChapter;
        private System.Windows.Forms.Label lblDifficultyValue;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.Label lblTimePlayedValue;
        private System.Windows.Forms.Label lblSlotValue;
        private System.Windows.Forms.Label lblSlot;
        private System.Windows.Forms.Label lblTimePlayed;
        private System.Windows.Forms.NumericUpDown nudCredits;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.Label lblNodes;
        private System.Windows.Forms.NumericUpDown nudNodes;
        private System.Windows.Forms.CheckBox cbInfiniteStasis;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator separator1ToolStripMenuItem;
        private System.Windows.Forms.Button btnEditItems;
        private System.Windows.Forms.CheckBox cbInfiniteAmmo;
        private System.Windows.Forms.ComboBox cbActiveSuit;
        private System.Windows.Forms.Label lblActiveSuit;
    }
}

