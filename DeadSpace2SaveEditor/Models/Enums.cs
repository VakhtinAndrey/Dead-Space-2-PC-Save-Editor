namespace DeadSpace2SaveEditor.Models
{
    public enum Difficulty
    {
        Easy = 0,
        Normal = 1,
        Hard = 2,
        VeryHard = 3,
        Impossible = 4
    }

    public enum Flags : byte
    {
        Unknown1,
        IsTied, // bugged
        Unknown3,
        KinesisIsActive,
        StasisIsActive,
        Unknown6,
        InfiniteAmmo,
        Unknown8
    }

    public enum ItemType
    {
        Unknown,
        Consumable,
        Ammo,
        Weapon,
        Suit,
        Schematic,
        Misc
    }
}
