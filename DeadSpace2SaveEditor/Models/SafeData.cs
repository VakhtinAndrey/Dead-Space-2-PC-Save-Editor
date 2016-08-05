using System.Collections.Generic;
using System.IO;
using DeadSpace2SaveEditor.Code;

namespace DeadSpace2SaveEditor.Models
{
    public class SafeEntity : BaseEntity
    {
        public uint Slot { get; set; }
        public uint Quantity { get; set; }
    }

    public class SafeData : IDataBlock, IEntityContainer<SafeEntity>
    {
        private const int itemSize = 4 * 6;
        public int ItemSize => itemSize;

        public int SafeCapacity { get; set; }
        public int Unk1 { get; set; }

        public List<SafeEntity> Items { get; set; }

        public SafeData()
        {
            Items = null;
        }

        public SafeData(MemoryStream stream) : this()
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
            var currPos = stream.SearchForBytePattern(MagicStuff.SafeMagic);
            if (currPos == -1)
                return;

            Items = new List<SafeEntity>();

            stream.Seek(currPos + MagicStuff.SafeMagic.Length, SeekOrigin.Begin);
            var size = stream.ReadInt16() - 8;
            stream.Seek(2, SeekOrigin.Current);
            SafeCapacity = stream.ReadInt32();
            Unk1 = stream.ReadInt32();

            if (size < ItemSize)
                return;
            for (int i = 0; i < size / ItemSize; i++)
            {
                var id = stream.ReadGuid();
                var slot = stream.ReadUInt32();
                var quantity = stream.ReadUInt32();
                var desc = MagicStuff.GetItemDescriptor(id);

                Items.Add(new SafeEntity
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

            var currPos = (int)stream.SearchForBytePattern(MagicStuff.SafeMagic);
            if (currPos == -1)
            {
                return false;
            }
            currPos += MagicStuff.SafeMagic.Length;
            stream.Seek(currPos, SeekOrigin.Begin);
            var origSize = stream.ReadUInt16();
            stream.Seek(-2, SeekOrigin.Current);

            var ms = new MemoryStream();
            ms.WriteUInt16(GetDataSize());
            ms.WriteUInt16(8);
            ms.WriteInt32(SafeCapacity);
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
