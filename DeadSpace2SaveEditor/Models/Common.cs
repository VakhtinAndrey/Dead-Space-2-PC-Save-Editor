using System;
using System.Diagnostics;

namespace DeadSpace2SaveEditor.Models
{
    public class MC02Header
    {
        public uint Magic;
        public uint TotalLength;
        public uint Chunk0Length;
        public uint Chunk1Length;
        public uint Checksum0;
        public uint Checksum1;
        public uint Checksum2;
    }

    public class FileMetadata
    {
        public string Slot;
        public string HoursPlayed;
        public string MinutesPlayed;
        public string SecondsPlayed;
        public string Difficulty;
        public string Chapter;
        public string Round;

        public string GetTimeString()
        {
            return $"{HoursPlayed}:{MinutesPlayed}:{SecondsPlayed}";
        }
    }

    [DebuggerDisplay("[{Type}] {Title}")]
    public class ItemDescriptor
    {
        public Guid Id { get; }

        public ItemType Type { get; }

        public string Code { get; }

        public string Title
        {
            get
            {
                if (Code != null)
                    return TranslateResources.ResourceManager.GetString($"{Type}_{Code}") ?? Code;

                string title;
                switch (Type)
                {
                    case ItemType.Consumable:
                        title = "<UNK_CONS> {{{0}}}";
                        break;
                    case ItemType.Ammo:
                        title = "<UNK_AMMO> {{{0}}}";
                        break;
                    case ItemType.Weapon:
                        title = "<UNK_WPN> {{{0}}}";
                        break;
                    case ItemType.Suit:
                        title = "<UNK_SUIT> {{{0}}}";
                        break;
                    case ItemType.Schematic:
                        title = "<UNK_SCH> {{{0}}}";
                        break;
                    case ItemType.Misc:
                        title = "<UNK_MISC> {{{0}}}";
                        break;
                    default:
                        title = "<UNK_ITEM> {{{0}}}";
                        break;
                }
                return string.Format(title, Id);
            }
        }

        public static ItemDescriptor Empty => new ItemDescriptor(Guid.Empty, ItemType.Unknown, null);

        public ItemDescriptor() : this(Guid.NewGuid())
        {

        }

        public ItemDescriptor(Guid id) : this(id, ItemType.Unknown, null)
        {

        }

        public ItemDescriptor(Guid id, ItemType type, string code)
        {
            Id = id;
            Type = type;
            Code = code;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                const int p = 16777619;
                int hash = (int)2166136261;

                byte[] id = Id.ToByteArray();
                for (int i = 0; i < id.Length; i++)
                    hash = (hash ^ id[i]) * p;

                hash += hash << 13;
                hash ^= hash >> 7;
                hash += hash << 3;
                hash ^= hash >> 17;
                hash += hash << 5;
                return hash;
            }
        }

        protected bool Equals(ItemDescriptor other)
        {
            return Id.Equals(other.Id);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((ItemDescriptor)obj);
        }
    }

    public abstract class BaseEntity
    {
        public ItemDescriptor Descriptor { get; set; }
    }
}
