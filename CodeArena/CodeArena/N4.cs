using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeArena
{
    static class N4
    {
        public static void Excecute()
        {
            int[] NM = Console.ReadLine().TrimEnd().Split().Select(int.Parse).ToArray();
            int min = 0;
            var routes = new Dictionary<int, List<int>>();
            for (int i = 0; i < NM[1]; i++)
            {
                int[] SE = Console.ReadLine().TrimEnd().Split().Select(int.Parse).ToArray();
                if (!routes.Keys.Contains(SE[0]))
                {
                    routes.Add(SE[0], new List<int>());
                }
                routes[SE[0]].Add(SE[1]);
                if (!routes.Keys.Contains(SE[1]))
                {
                    routes.Add(SE[1], new List<int>());
                }
                routes[SE[1]].Add(SE[0]);
            }
            if (routes.Count < NM[0])
            {
                min += NM[0] - routes.Count;
            }
            while (routes.Count > 0)
            {
                var max = -1;
                int maxKey = -1;
                foreach (var key in routes)
                {
                    if (key.Value.Count > max)
                    {
                        max = key.Value.Count;
                        maxKey = key.Key;
                    }
                }
                foreach (var value in routes[maxKey])
                {
                    if (routes.ContainsKey(value))
                    {
                        if (routes[value].Count == 1)
                            routes.Remove(value);
                        else
                            routes[value].Remove(maxKey);
                    }
                }
                routes.Remove(maxKey);
                min++;
            }
            Console.WriteLine(min);
        }
    }
}
