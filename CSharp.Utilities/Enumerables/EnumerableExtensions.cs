using System;
using System.Collections.Generic;

namespace CSharp.Utilities.Enumerables
{
    public static class EnumerableExtensions
    {
        public static void Add<T>(this List<T> list, params T[] elements)
        {
            list.AddRange(elements);
        }

        public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            var seenKeys = new HashSet<TKey>();

            foreach (var element in source)
            {
                if (seenKeys.Add(keySelector(element)))
                {
                    yield return element;
                }
            }
        }
    }
}
