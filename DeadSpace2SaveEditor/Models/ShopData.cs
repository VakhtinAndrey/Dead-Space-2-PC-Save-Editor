using System.Collections.Generic;
using System.IO;
using DeadSpace2SaveEditor.Code;

namespace DeadSpace2SaveEditor.Models
{
    public class ShopEntity : BaseEntity
    {
        public int Unk1 { get; set; }
    }

    public class ShopData : IDataBlock, IEntityContainer<ShopEntity>
    {
        private const int itemSize = 4 * 5;
        public int ItemSize => itemSize;

        public int Unk1 { get; set; }

        public List<ShopEntity> Items { get; set; }

        public ShopData()
        {
            Items = null;
        }

        public ShopData(MemoryStream stream) : this()
        {
            ReadData(stream);
        }

        public ushort GetDataSize()
        {
            return (ushort)(4 + Items.Count * ItemSize);
        }

        public void ReadData(MemoryStream stream)
        {
            var origPos = stream.Position;
            var currPos = stream.SearchForBytePattern(MagicStuff.ShopMagic);
            if (currPos == -1)
                return;

            Items = new List<ShopEntity>();

            stream.Seek(currPos + MagicStuff.ShopMagic.Length, SeekOrigin.Begin);
            var size = stream.ReadInt16() - 4;
            stream.Seek(2, SeekOrigin.Current);
            Unk1 = stream.ReadInt32();

            if (size < ItemSize)
                return;
            for (int i = 0; i < size / ItemSize; i++)
            {
                var id = stream.ReadGuid();
                var unk = stream.ReadInt32();
                var desc = MagicStuff.GetItemDescriptor(id);

                Items.Add(new ShopEntity
                {
                    Unk1 = unk,
                    Descriptor = desc
                });
            }

            stream.Position = origPos;
        }

        public bool WriteData(MemoryStream stream)
        {
            var origPos = stream.Position;

            var currPos = (int)stream.SearchForBytePattern(MagicStuff.ShopMagic);
            if (currPos == -1)
            {
                return false;
            }
            currPos += MagicStuff.ShopMagic.Length;
            stream.Seek(currPos, SeekOrigin.Begin);
            var origSize = stream.ReadUInt16();
            stream.Seek(-2, SeekOrigin.Current);

            var ms = new MemoryStream();
            ms.WriteUInt16(GetDataSize());
            ms.WriteUInt16(8);
            ms.WriteInt32(Unk1);
            foreach (var item in Items)
            {
                ms.WriteGuid(item.Descriptor.Id);
                ms.WriteInt32(item.Unk1);
            }

            var newData = ms.ToArray();
            stream.Replace(currPos, origSize + 4, newData);

            stream.Position = origPos;
            return true;
        }
    }
}
