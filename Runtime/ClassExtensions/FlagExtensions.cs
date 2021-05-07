namespace Toolbox
{
    public static class FlagExtensions
    {
        public static int AddFlag(this int value, int flag) { return value |= flag; }
        public static int RemoveFlag(this int value, int flag) { return value &= ~flag; }
        public static bool ContainsFlag(this int value, int flag) { return (value & flag) != 0; }
    }
}
