using System;
using System.Collections.Generic;
using System.Linq;

namespace Toolbox
{
    public static class SystemTypeExtensions
    {
        public static IEnumerable<Type> GetAssignable(this Type type)
        {
            Type[] existingTypes = type.Assembly.GetTypes();
            foreach (Type t in existingTypes.Where(type.IsAssignableFrom))
            {
                if (t.IsClass && !t.IsAbstract && !t.IsGenericType)
                    yield return t;
            }
        }
    }
}
