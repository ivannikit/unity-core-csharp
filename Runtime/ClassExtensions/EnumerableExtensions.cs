using System.Collections;

namespace TeamZero
{
    public static class EnumerableExtensions
    {
        public static bool IsNullOrEmpty(IEnumerable enumerable)
        {
            return enumerable == null || enumerable.IsEmpty();
        }

        public static bool IsEmpty(this IEnumerable enumerable)
        {
            ICollection collection = enumerable as ICollection;
            if (collection != null)
            {
                return collection.Count == 0;
            }
            else
            {
                var enumerator = enumerable.GetEnumerator();
                return !enumerator.MoveNext();
            }
        }
    }
}
