using System;

namespace TeamZero.Core
{
    [Flags]
    public enum Axis3
    {
        None = 0,
        All = ~None,
        X = 1 << 0,
        Y = 1 << 1,
        Z = 1 << 2,
        XY = X | Y
    }

    [Flags]
    public enum Axis2
    {
        None = 0,
        All = ~None,
        X = 1 << 0,
        Y = 1 << 1,
        XY = X | Y
    }
}
