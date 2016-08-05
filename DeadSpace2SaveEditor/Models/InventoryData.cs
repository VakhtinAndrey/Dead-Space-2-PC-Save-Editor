using System.Collections.Generic;
using System.IO;
using DeadSpace2SaveEditor.Code;

namespace DeadSpace2SaveEditor.Models
{
    public class InventoryEntity : BaseEntity
    {
        public uint Slot { get; set; }
        public uint Quantity { get; set; }
    }

    public class InventoryData : IDataBlock, IEntityContainer<InventoryEntity>
    {
        private const int itemSize = 4 * 6;
        public int ItemSize => itemSize;

        public int Unk1 { get; set; }
        public uint Credits { get; set; }

        public List<InventoryEntity> Items { get; set; }

        public InventoryData()
        {
            Items = null;
        }

        public InventoryData(MemoryStream stream) : this()
        {
            ReadData(stream);
        }

        public ushort GetDataSize()
        {
            return (ushort)(8 + Items.Count * 4 * 6);
        }

        public void ReadData(MemoryStream stream)
        {
            var origPos = stream.Position;
            var currPos = stream.SearchForBytePattern(MagicStuff.InventoryMagic);
            if (currPos == -1)
                return;

            Items = new List<InventoryEntity>();

            stream.Seek(currPos + MagicStuff.InventoryMagic.Length, SeekOrigin.Begin);
            var size = stream.ReadInt16() - 8;
            stream.Seek(2, SeekOrigin.Current);
            Unk1 = stream.ReadInt32();
            Credits = stream.ReadUInt32();

            if (size < ItemSize)
                return;
            for (int i = 0; i < size / ItemSize; i++)
            {
                var id = stream.ReadGuid();
                var slot = stream.ReadUInt32();
                var quantity = stream.ReadUInt32();
                var desc = MagicStuff.GetItemDescriptor(id);

                Items.Add(new InventoryEntity
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

            var currPos = (int)stream.SearchForBytePattern(MagicStuff.InventoryMagic);
            if (currPos == -1)
            {
                return false;
            }
            currPos += MagicStuff.InventoryMagic.Length;
            stream.Seek(currPos, SeekOrigin.Begin);
            var origSize = stream.ReadUInt16();
            stream.Seek(-2, SeekOrigin.Current);

            var ms = new MemoryStream();
            ms.WriteUInt16(GetDataSize());
            ms.WriteUInt16(8);
            ms.WriteInt32(Unk1);
            ms.WriteUInt32(Credits);
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
