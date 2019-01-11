using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeArena
{
    static class N5
    {
        public static void Excecute()
        {
            int[] NQ = Console.ReadLine().TrimEnd().Split().Select(int.Parse).ToArray();
            long[] numbers = Console.ReadLine().TrimEnd().Split().Select(long.Parse).ToArray();
            var rounds = new List<int>();
            var count = 0;
            var countP = new List<int>();
            var countL = new List<int>();
            for (int i = 0; i< numbers.Length; i++)
            {
                if (IsRound(numbers[i])) {
                    rounds.Add(1);
                    count++;
                }
                else rounds.Add(0);
                numbers[i] = count;
            }
            for (int i = 0; i < NQ[1]; i++)
            {
                long[] values = Console.ReadLine().TrimEnd().Split().Select(long.Parse).ToArray();
                switch (values[0])
                {
                    case 1:
                        var sum = rounds[(int)values[1] - 1] == 1 || rounds[(int)values[2] - 1] == 1 ? 1 : 0;
                        var sum2 = countP.Count(v => v <= (int)values[2] - 1);
                        var sum3 = countL.Count(v => v <= (int)values[2] - 1);
                        Console.WriteLine(numbers[(int)values[2] - 1] - numbers[(int)values[1] - 1] + sum+sum2-sum3);
                        break;
                    case 2:
                        if (IsRound(values[2]))
                        {
                            if (rounds[(int)(values[1] - 1)] == 0)
                            {
                                rounds[(int)(values[1] - 1)] = 1;
                                countP.Add((int)(values[1] - 1));
                            }
                        }
                        else
                        {
                            if (rounds[(int)(values[1] - 1)] == 1)
                            {
                                rounds[(int)(values[1] - 1)] = 0;
                                countL.Add((int)(values[1] - 1));
                            }
                        }
                        break;
                }
            }
        }

        private static bool IsRound(long number)
        {
            var numberString = number.ToString();
            if (numberString[0] == '-') return false;
            if (numberString.Length == 1) return true;
            if (numberString[numberString.Length - 1] == numberString[0]) return true;
            return false;
        }
    }
}
