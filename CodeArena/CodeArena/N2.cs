using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeArena
{
    static class N2
    {
        public static void Excecute()
        {
            int T = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int[] MN = Console.ReadLine().TrimEnd().Split().Select(int.Parse).ToArray();
                int[] boys = Console.ReadLine().TrimEnd().Split().Select(int.Parse).ToArray();
                int[] girls = Console.ReadLine().TrimEnd().Split().Select(int.Parse).ToArray();

                Array.Sort(boys);
                Array.Sort(girls);
                var response = "NO";
                if (MN[1] >= MN[0])
                {
                    int count = 0;
                    while (count < boys.Count())
                    {
                        if (boys[count] <= girls[count])
                        {
                            break;
                        }
                        count++;
                    }
                    if (count == boys.Count())
                    {
                        response = "YES";
                    }
                }
                Console.WriteLine(response);
            }
        }
    }
}
