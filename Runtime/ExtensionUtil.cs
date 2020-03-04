using System.Collections.Generic;
using Random = System.Random;

namespace Utility
{
    public static class CollectionExtension
    {
        private static Random rng = new Random();

        public static T RandomElement<T>(this IList<T> list)
        {
            return list[rng.Next(list.Count)];
        }

        public static T GetLast<T>(this IList<T> list)
        {
            return list[list.Count - 1];
        }
        public static void RemoveFromLast<T>(this IList<T> list)
        {
            list.RemoveAt(list.Count - 1);
        }
        public static T RandomElement<T>(this T[] array)
        {
            return array[rng.Next(array.Length)];
        }
    }
}

