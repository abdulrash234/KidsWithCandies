using System;
using System.Collections.Generic;
using System.Linq;

namespace KidsWithCandies
{
    class Program
    {
        static void Main(string[] args)
        {
            var candies = new int[] {2, 3, 5, 1, 3};
            var list = KidsWithCandies(candies, 3);
            foreach (var val in list)
            {
                Console.WriteLine(val);
            }
        }

        public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {

            var count = candies.Length;
            var list = new List<bool>(count);
            for (int i = 0; i < candies.Count(); i++)
            {
                var highestCandiesPossible = candies[i] + extraCandies;
                var isGreatest = true;
                for (int j = 0; j < count; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    if (highestCandiesPossible < candies[j])
                    {
                        isGreatest = false;
                    }
                }
                list.Add(isGreatest);
            }
            return list;
        }
    }
}
