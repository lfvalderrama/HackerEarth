using System;
using System.Collections.Generic;
using System.Text;

namespace CodeArena
{
    /// <summary>
    /// Who Wants to be a Millionaire!? Hacker Earth
    /// </summary>
    static class N1
    {
        public static void Excecute()
        {
            int T = Int32.Parse(Console.ReadLine());
            for (int i =0; i<T; i++)
            {
                double N = Int32.Parse(Console.ReadLine());
                var result = (N-1)/N;
                Console.WriteLine(result.ToString("N6"));
            }
        }
    }
}
