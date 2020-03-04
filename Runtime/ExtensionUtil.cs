using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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

        public static IList<T> RemoveDuplicateEntry<T>(IList<T> list)
        {
            return list.Distinct().ToList();
        }

        public static IList<T> CloneOfList<T>(IList<T> list)
        {
            List<T> clone = new List<T>();
            for (int i = 0; i < list.Count; i++)
            {
                clone.Add(list[i]);
            }
            return clone;
        }

        public static T RandomElement<T>(this T[] array)
        {
            return array[rng.Next(array.Length)];
        }
    }

    public static class StringExtension
    {
        public static bool IsEmail(this string email)
        {
            string MatchEmailPattern =
                @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
                + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
                  + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
                + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";

            return email != null && Regex.IsMatch(email, MatchEmailPattern);
        }

    }
}

