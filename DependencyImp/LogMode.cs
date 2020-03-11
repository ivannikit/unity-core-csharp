using System;

namespace Toolbox
{
    [Flags]
    public enum LogMode
    {
        None = 0,
        All = ~None,
        Info = 1 << 0,
        Warning = 1 << 1,
        Error = 1 << 2,
    }
}