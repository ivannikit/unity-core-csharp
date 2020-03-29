using System;
using System.Collections.Generic;
using System.Linq;

namespace Toolbox
{
    public static partial class Help
    {
        public static IEnumerable<T> GetEnumValues<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }
    }
}
