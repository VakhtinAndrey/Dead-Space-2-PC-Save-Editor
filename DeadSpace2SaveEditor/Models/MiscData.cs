using System.IO;
using DeadSpace2SaveEditor.Code;

namespace DeadSpace2SaveEditor.Models
{
    public class MiscData : IDataBlock
    {
        public float Health { get; set; }
        public float Stasis { get; set; }
        public float Air { get; set; }
        public uint Nodes { get; set; }
        public int Unk1 { get; set; }
        public ItemDescriptor ActiveSuit { get; set; }
        public int UnlockedLogChapters { get; set; }
        public int InventorySlots { get; set; }
        public float DamageRatio { get; set; }
        public int Unk3 { get; set; }
        public byte[] Flags { get; set; }
        public byte[] UnkBar1 { get; set; }

        public MiscData()
        {
            Flags = new byte[8];
            UnkBar1 = new byte[5*16];
        }

        public MiscData(MemoryStream stream) : this()
        {
            ReadData(stream);
        }

        public ushort GetDataSize()
        {
            return (ushort)4 * 15 + 4 * 20;
        }

        public void ReadData(MemoryStream stream)
        {
            var origPos = stream.Position;
            var pos = stream.SearchForBytePattern(MagicStuff.MiscMagic);
            if (pos == -1)
                return;

            stream.Seek(pos + MagicStuff.SafeMagic.Length + 4, SeekOrigin.Begin);

            Health = stream.ReadFloat();
            Stasis = stream.ReadFloat();
            Air = stream.ReadFloat();
            Nodes = stream.ReadUInt32();
            Unk1 = stream.ReadInt32();
            var activeSuitId = stream.ReadGuid();
            ActiveSuit = MagicStuff.GetItemDescriptor(activeSuitId, ItemType.Suit);
            UnlockedLogChapters = stream.ReadInt32();
            InventorySlots = stream.ReadInt32();
            DamageRatio = stream.ReadFloat();
            Unk3 = stream.ReadInt32();
            //System.Windows.Forms.MessageBox.Show(stream.Position.ToString("X"));
            stream.Read(Flags, 0, 8);
            stream.Read(UnkBar1, 0, UnkBar1.Length);
            stream.Position = origPos;
        }

        public bool WriteData(MemoryStream stream)
        {
            var origPos = stream.Position;

            var currPos = (int)stream.SearchForBytePattern(MagicStuff.MiscMagic);
            if (currPos == -1)
            {
                return false;
            }
            currPos += MagicStuff.MiscMagic.Length;
            stream.Seek(currPos, SeekOrigin.Begin);
            var origSize = stream.ReadUInt16();
            stream.Seek(-2, SeekOrigin.Current);

            var ms = new MemoryStream();
            ms.WriteUInt16(GetDataSize());
            ms.WriteUInt16(8);
            ms.WriteFloat(Health);
            ms.WriteFloat(Stasis);
            ms.WriteFloat(Air);
            ms.WriteUInt32(Nodes);
            ms.WriteInt32(Unk1);
            ms.WriteGuid(ActiveSuit.Id);
            ms.WriteInt32(UnlockedLogChapters);
            ms.WriteInt32(InventorySlots);
            ms.WriteFloat(DamageRatio);
            ms.WriteInt32(Unk3);
            ms.Write(Flags, 0, Flags.Length); 
            ms.Write(UnkBar1, 0, UnkBar1.Length); 
            /*
            for (int i = 0; i < 20; i++)
            {
                ms.WriteInt32(0);
            }
            */
            var newData = ms.ToArray();
            stream.Replace(currPos, origSize + 4, newData);

            stream.Position = origPos;
            return true;
        }
    }
}
