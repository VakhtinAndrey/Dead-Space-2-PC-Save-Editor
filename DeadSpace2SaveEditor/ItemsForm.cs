using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DeadSpace2SaveEditor.Code;
using DeadSpace2SaveEditor.Models;

namespace DeadSpace2SaveEditor
{
    public partial class ItemsForm : Form
    {
        private const string ItemSelect = "<select>";
        private const string ItemNone = "<none>";
        private const string ItemAuto = "<auto>";
        private const string ItemCategoryUnknown = "--------------- UNKNOWN ---------------";
        private const string ItemCategoryConsumable = "--------------- Consumable ---------------";
        private const string ItemCategoryAmmo = "--------------- Ammo ---------------";
        private const string ItemCategoryWeapons = "--------------- Weapons ---------------";
        private const string ItemCategorySuits = "--------------- Suits ---------------";
        private const string ItemCategorySchematic = "--------------- Schematic ---------------";
        private const string ItemCategoryMiscellaneous = "--------------- Miscellaneous ---------------";

        private List<Guid> GuidStoplist { get; set; }

        public InventoryData InventoryData { get; set; }
        public SafeData SafeData { get; set; }
        public ShopData ShopData { get; set; }
        public WeaponsData WeaponsData { get; set; }

        public ItemsForm(InventoryData inventoryData, SafeData safeData, ShopData shopData, WeaponsData weaponsData)
        {
            InitializeComponent();

            GuidStoplist = new List<Guid>();

            InventoryData = inventoryData;
            SafeData = safeData;
            ShopData = shopData;
            WeaponsData = weaponsData;

            var dsInventory = GetInventoryDataSource();
            var dsWeapons = GetWeaponsDataSource();
            var dsSafe = GetSafeDataSource();
            var dsShop = GetShopDataSource();
            
            if (InventoryData != null)
                foreach (var item in InventoryData.Items)
                {
                    dgvInventory.Rows.Add(
                        item.Slot,
                        item.Descriptor,
                        item.Quantity);
                }

            if (WeaponsData != null)
                for (int i = 0; i < 4; i++)
                {
                    var item = WeaponsData.Items.FirstOrDefault(it => it.Slot == i);
                    dgvWeapons.Rows.Add(
                        i,
                        item?.Descriptor ?? ItemDescriptor.Empty,
                        item?.Quantity ?? 0);
                }
            
            if (SafeData != null)
                foreach (var item in SafeData.Items)
                {
                    dgvSafe.Rows.Add(
                        item.Slot,
                        item.Descriptor,
                        item.Quantity);
                }
            
            if (ShopData != null)
                foreach (var item in ShopData.Items)
                {
                    dgvShop.Rows.Add(item.Descriptor);
                }
            
            colInventoryName.DisplayMember = "Value";
            colInventoryName.ValueMember = "Key";
            colInventoryName.DataSource = new BindingSource(dsInventory, null);

            colWeaponsName.DisplayMember = "Value";
            colWeaponsName.ValueMember = "Key";
            colWeaponsName.DataSource = new BindingSource(dsWeapons.OrderBy(d => d.Value), null);

            colSafeName.DisplayMember = "Value";
            colSafeName.ValueMember = "Key";
            colSafeName.DataSource = new BindingSource(dsSafe, null);

            colShopName.DisplayMember = "Value";
            colShopName.ValueMember = "Key";
            colShopName.DataSource = new BindingSource(dsShop, null);
        }

        private void AddRestrictedItem(Dictionary<ItemDescriptor, string> dict, string title)
        {
            var guid = Guid.NewGuid();
            GuidStoplist.Add(guid);
            dict.Add(new ItemDescriptor(guid), title);
        }

        private bool IsItemRestricted(Guid id)
        {
            return GuidStoplist.Any(g => g == id);
        }

        #region Data Sources

        private Dictionary<ItemDescriptor, string> GetWeaponsDataSource()
        {
            var result = new Dictionary<ItemDescriptor, string>();

            result.Add(ItemDescriptor.Empty, ItemNone);

            foreach (var desc in MagicStuff.ItemDescriptors.Where(d => d.Type == ItemType.Weapon))
            {
                result.Add(desc, desc.Title);
            }

            return result;
        }

        private Dictionary<ItemDescriptor, string> GetInventoryDataSource()
        {
            var result = new Dictionary<ItemDescriptor, string>();

            result.Add(ItemDescriptor.Empty, ItemSelect);

            AddRestrictedItem(result, ItemCategoryConsumable);
            foreach (var desc in MagicStuff.ItemDescriptors.Where(d => d.Type == ItemType.Consumable))
            {
                result.Add(desc, desc.Title);
            }
            
            AddRestrictedItem(result, ItemCategoryAmmo);
            foreach (var desc in MagicStuff.ItemDescriptors.Where(d => d.Type == ItemType.Ammo))
            {
                result.Add(desc, desc.Title);
            }

            AddRestrictedItem(result, ItemCategorySuits);
            foreach (var desc in MagicStuff.ItemDescriptors.Where(d => d.Type == ItemType.Suit))
            {
                result.Add(desc, desc.Title);
            }

            AddRestrictedItem(result, ItemCategorySchematic);
            foreach (var desc in MagicStuff.ItemDescriptors.Where(d => d.Type == ItemType.Schematic))
            {
                result.Add(desc, desc.Title);
            }

            AddRestrictedItem(result, ItemCategoryMiscellaneous);
            foreach (var desc in MagicStuff.ItemDescriptors.Where(d => d.Type == ItemType.Misc))
            {
                result.Add(desc, desc.Title);
            }

            if (MagicStuff.ItemDescriptors.Any(d => d.Type == ItemType.Unknown))
            {
                AddRestrictedItem(result, ItemCategoryUnknown);
                foreach (var desc in MagicStuff.ItemDescriptors.Where(d => d.Type == ItemType.Unknown))
                {
                    result.Add(desc, desc.Title);
                }
            }

            return result;
        }

        private Dictionary<ItemDescriptor, string> GetSafeDataSource()
        {
            var result = new Dictionary<ItemDescriptor, string>();

            result.Add(ItemDescriptor.Empty, ItemSelect);

            AddRestrictedItem(result, ItemCategoryConsumable);
            foreach (var desc in MagicStuff.ItemDescriptors.Where(d => d.Type == ItemType.Consumable))
            {
                result.Add(desc, desc.Title);
            }

            AddRestrictedItem(result, ItemCategoryAmmo);
            foreach (var desc in MagicStuff.ItemDescriptors.Where(d => d.Type == ItemType.Ammo))
            {
                result.Add(desc, desc.Title);
            }

            AddRestrictedItem(result, ItemCategoryWeapons);
            foreach (var desc in MagicStuff.ItemDescriptors.Where(d => d.Type == ItemType.Weapon))
            {
                result.Add(desc, desc.Title);
            }

            AddRestrictedItem(result, ItemCategorySuits);
            foreach (var desc in MagicStuff.ItemDescriptors.Where(d => d.Type == ItemType.Suit))
            {
                result.Add(desc, desc.Title);
            }

            AddRestrictedItem(result, ItemCategorySchematic);
            foreach (var desc in MagicStuff.ItemDescriptors.Where(d => d.Type == ItemType.Schematic))
            {
                result.Add(desc, desc.Title);
            }

            AddRestrictedItem(result, ItemCategoryMiscellaneous);
            foreach (var desc in MagicStuff.ItemDescriptors.Where(d => d.Type == ItemType.Misc))
            {
                result.Add(desc, desc.Title);
            }

            if (MagicStuff.ItemDescriptors.Any(d => d.Type == ItemType.Unknown))
            {
                AddRestrictedItem(result, ItemCategoryUnknown);
                foreach (var desc in MagicStuff.ItemDescriptors.Where(d => d.Type == ItemType.Unknown))
                {
                    result.Add(desc, desc.Title);
                }
            }

            return result;
        }

        private Dictionary<ItemDescriptor, string> GetShopDataSource()
        {
            var result = new Dictionary<ItemDescriptor, string>();

            result.Add(ItemDescriptor.Empty, ItemSelect);

            AddRestrictedItem(result, ItemCategoryConsumable);
            foreach (var desc in MagicStuff.ItemDescriptors.Where(d => d.Type == ItemType.Consumable))
            {
                result.Add(desc, desc.Title);
            }

            AddRestrictedItem(result, ItemCategoryAmmo);
            foreach (var desc in MagicStuff.ItemDescriptors.Where(d => d.Type == ItemType.Ammo))
            {
                result.Add(desc, desc.Title);
            }

            AddRestrictedItem(result, ItemCategoryWeapons);
            foreach (var desc in MagicStuff.ItemDescriptors.Where(d => d.Type == ItemType.Weapon))
            {
                result.Add(desc, desc.Title);
            }

            AddRestrictedItem(result, ItemCategorySuits);
            foreach (var desc in MagicStuff.ItemDescriptors.Where(d => d.Type == ItemType.Suit))
            {
                result.Add(desc, desc.Title);
            }

            AddRestrictedItem(result, ItemCategorySchematic);
            foreach (var desc in MagicStuff.ItemDescriptors.Where(d => d.Type == ItemType.Schematic))
            {
                result.Add(desc, desc.Title);
            }

            AddRestrictedItem(result, ItemCategoryMiscellaneous);
            foreach (var desc in MagicStuff.ItemDescriptors.Where(d => d.Type == ItemType.Misc))
            {
                result.Add(desc, desc.Title);
            }

            if (MagicStuff.ItemDescriptors.Any(d => d.Type == ItemType.Unknown))
            {
                AddRestrictedItem(result, ItemCategoryUnknown);
                foreach (var desc in MagicStuff.ItemDescriptors.Where(d => d.Type == ItemType.Unknown))
                {
                    result.Add(desc, desc.Title);
                }
            }

            return result;
        }
        #endregion

        private void dgvInventory_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[colInventorySlot.Name].Value = ItemAuto;
            e.Row.Cells[colInventoryName.Name].Value = ItemDescriptor.Empty;
            e.Row.Cells[colInventoryQuantity.Name].Value = "0";
        }

        private void dgvSafe_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[colSafeSlot.Name].Value = ItemAuto;
            e.Row.Cells[colSafeName.Name].Value = ItemDescriptor.Empty;
            e.Row.Cells[colSafeQuantity.Name].Value = "0";
        }

        private void dgvShop_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[colShopName.Name].Value = ItemDescriptor.Empty;
        }

        private void btnAddSuitsWeapons_Click(object sender, EventArgs e)
        {
            if (SafeData == null)
                return;

            var items = new List<SafeEntity>();
            uint slot = 0;
            foreach (var item in SafeData.Items)
            {
                if ((item.Descriptor.Type != ItemType.Suit &&
                    item.Descriptor.Type != ItemType.Weapon))
                {
                    items.Add(new SafeEntity
                    {
                        Slot = slot++,
                        Quantity = item.Quantity,
                        Descriptor = item.Descriptor
                    });
                }
            }

            foreach (var desc in MagicStuff.ItemDescriptors.Where(d => d.Type == ItemType.Suit))
            {
                items.Add(new SafeEntity
                {
                    Slot = slot++,
                    Quantity = 1,
                    Descriptor = desc
                });
            }

            foreach (var desc in MagicStuff.ItemDescriptors.Where(d => d.Type == ItemType.Weapon))
            {
                items.Add(new SafeEntity
                {
                    Slot = slot++,
                    Quantity = 100,
                    Descriptor = desc
                });
            }

            SafeData.Items = items;
            dgvSafe.Rows.Clear();
            foreach (var item in items)
            {
                dgvSafe.Rows.Add(
                    item.Slot,
                    item.Descriptor,
                    item.Quantity);
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (InventoryData == null || SafeData == null || ShopData == null || WeaponsData == null)
                return;

            InventoryData.Items.Clear();
            WeaponsData.Items.Clear();
            SafeData.Items.Clear();
            ShopData.Items.Clear();
            
            uint quantity;
            uint counter;

            counter = 0;
            foreach (var row in dgvInventory.Rows.OfType<DataGridViewRow>().DropLast())
            {
                var value = row.Cells[colInventoryName.Name].Value as ItemDescriptor;
                if (value != null && !value.Equals(ItemDescriptor.Empty) && !IsItemRestricted(value.Id))
                {
                    uint.TryParse(row.Cells[colInventoryQuantity.Name].Value.ToString(), out quantity);

                    InventoryData.Items.Add(new InventoryEntity
                    {
                        Quantity = quantity < 1 ? 1 : quantity,
                        Slot = counter,
                        Descriptor = new ItemDescriptor(value.Id, value.Type, value.Code)
                    });
                }
                counter++;
            }

            foreach (var row in dgvWeapons.Rows.OfType<DataGridViewRow>())
            {
                var value = row.Cells[colWeaponsName.Name].Value as ItemDescriptor;
                if (value != null && !value.Equals(ItemDescriptor.Empty))
                {
                    uint.TryParse(row.Cells[colWeaponsQuantity.Name].Value.ToString(), out quantity);

                    WeaponsData.Items.Add(new WeaponEntity
                    {
                        Quantity = quantity < 1 ? 1 : quantity,
                        Slot = uint.Parse(row.Cells[colWeaponsSlot.Name].Value.ToString()),
                        Descriptor = new ItemDescriptor(value.Id, value.Type, value.Code)
                    });
                }
            }

            counter = 0;
            foreach (var row in dgvSafe.Rows.OfType<DataGridViewRow>().DropLast())
            {
                var value = row.Cells[colSafeName.Name].Value as ItemDescriptor;
                if (value != null && !value.Equals(ItemDescriptor.Empty) && !IsItemRestricted(value.Id))
                {
                    uint.TryParse(row.Cells[colSafeQuantity.Name].Value.ToString(), out quantity);

                    SafeData.Items.Add(new SafeEntity
                    {
                        Quantity = quantity < 1 ? 1 : quantity,
                        Slot = counter,
                        Descriptor = new ItemDescriptor(value.Id, value.Type, value.Code)
                    });
                }
                counter++;
            }

            counter = 0;
            foreach (var row in dgvShop.Rows.OfType<DataGridViewRow>().DropLast())
            {
                var value = row.Cells[colShopName.Name].Value as ItemDescriptor;
                if (value != null && !value.Equals(ItemDescriptor.Empty) && !IsItemRestricted(value.Id))
                {
                    ShopData.Items.Add(new ShopEntity
                    {
                        Unk1 = 0,
                        Descriptor = new ItemDescriptor(value.Id, value.Type, value.Code)
                    });
                }
                counter++;
            }

            this.Close();
        }
    }
}
