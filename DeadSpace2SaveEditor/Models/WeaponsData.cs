using System.Collections.Generic;
using System.IO;
using DeadSpace2SaveEditor.Code;

namespace DeadSpace2SaveEditor.Models
{
    public class WeaponEntity : BaseEntity
    {
        public uint Slot { get; set; }
        public uint Quantity { get; set; }
    }

    public class WeaponsData : IDataBlock, IEntityContainer<WeaponEntity>
    {
        private const int itemSize = 4 * 6;
        public int ItemSize => itemSize;

        public int ActiveSlots { get; set; }

        public int Unk1 { get; set; }

        public List<WeaponEntity> Items { get; set; }

        public WeaponsData()
        {
            Items = null;
        }

        public WeaponsData(MemoryStream stream) : this()
        {
            ReadData(stream);
        }

        public ushort GetDataSize()
        {
            return (ushort)(8 + Items.Count * ItemSize);
        }

        public void ReadData(MemoryStream stream)
        {
            var origPos = stream.Position;
            var currPos = stream.SearchForBytePattern(MagicStuff.WeaponMagic);
            if (currPos == -1)
                return;

            Items = new List<WeaponEntity>();

            stream.Seek(currPos + MagicStuff.InventoryMagic.Length, SeekOrigin.Begin);
            var size = stream.ReadInt16() - 8;
            stream.Seek(2, SeekOrigin.Current);
            ActiveSlots = stream.ReadInt32();
            Unk1 = stream.ReadInt32();

            if (size < ItemSize)
                return;
            for (int i = 0; i < size / ItemSize; i++)
            {
                var id = stream.ReadGuid();
                var slot = stream.ReadUInt32();
                var quantity = stream.ReadUInt32();
                var desc = MagicStuff.GetItemDescriptor(id, ItemType.Weapon);

                Items.Add(new WeaponEntity
                {
                    Slot = slot,
                    Quantity = quantity,
                    Descriptor = desc
                });
            }

            stream.Position = origPos;
        }

        public bool WriteData(MemoryStream stream)
        {
            var origPos = stream.Position;

            var currPos = (int)stream.SearchForBytePattern(MagicStuff.WeaponMagic);
            if (currPos == -1)
            {
                return false;
            }
            currPos += MagicStuff.WeaponMagic.Length;
            stream.Seek(currPos, SeekOrigin.Begin);
            var origSize = stream.ReadUInt16();
            stream.Seek(-2, SeekOrigin.Current);

            var ms = new MemoryStream();
            ms.WriteUInt16(GetDataSize());
            ms.WriteUInt16(8);
            ms.WriteInt32(ActiveSlots);
            ms.WriteInt32(Unk1);
            foreach (var item in Items)
            {
                ms.WriteGuid(item.Descriptor.Id);
                ms.WriteUInt32(item.Slot);
                ms.WriteUInt32(item.Quantity);
            }

            var newData = ms.ToArray();
            stream.Replace(currPos, origSize + 4, newData);

            stream.Position = origPos;
            return true;
        }
    }
}
