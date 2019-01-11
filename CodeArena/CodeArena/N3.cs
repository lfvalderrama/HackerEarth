using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeArena
{
    static class N3
    {
        public static void Excecute()
        {
            int T = Int32.Parse(Console.ReadLine());
            var starts = new List<TimeSpan>();
            var ends = new List<TimeSpan>();
            for (int i = 0; i < T; i++)
            {
                string[] IF = Console.ReadLine().TrimEnd().Split("-").ToArray();
                var hm = TimeSpan.Parse(IF[0]);
                starts.Add(hm);
                hm = TimeSpan.Parse(IF[1]);
                ends.Add(hm);
            }

            for (int j = 0; j < starts.Count; j++)
            {
                for (int k =0; k<starts.Count; k++)
                {
                    var asd = starts[j];
                    var asd2 = starts[k];
                    var asd3 = ends[k];
                    if (starts[j] < ends[k] && starts[j] >= starts[k] && j!=k)
                    {
                        Console.WriteLine("Will need a moderator!");
                        return;
                    }
                }
            }
            Console.WriteLine("Who needs a moderator?");
        }
    }
}
