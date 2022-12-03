using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TeamZero
{
    public static class CollectionExtensions
    {
        public static bool IsNullOrEmpty(this ICollection target)
        {
            return target == null || target.Count == 0;
        }

        public static bool IsNotNullAndNotEmpty(this ICollection target)
        {
            return target != null && target.Count != 0;
        }

        public static string ToString(this ICollection target, string separator = ", ", string itemPrefix = "", string itemPostfix = "")
        {
            return ToFormatedString(target, separator, itemPrefix, itemPostfix);
        }

        public static string ToFormatedString(ICollection target, string separator = ", ", string itemPrefix = "", string itemPostfix = "")
        {
            if (!target.IsNullOrEmpty())
            {
                int i = 0;
                StringBuilder sb = new StringBuilder();
                foreach (object obj in target)
                {
                    sb.Append(String.Format("{0}{1}{2}{3}", itemPrefix, obj.ToString(), itemPostfix, (i < target.Count - 1) ? separator : ""));
                    i++;
                }
                return sb.ToString();
            }

            return string.Empty;
        }
    }
}
