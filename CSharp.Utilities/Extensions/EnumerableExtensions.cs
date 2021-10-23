using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Utilities.Extensions
{
    public static class EnumerableExtensions
    {
        public static void Add<T>(this List<T> list, params T[] elements)
        {
            list.AddRange(elements);
        }
    }
}
