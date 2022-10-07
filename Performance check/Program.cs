using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performance_check
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public void sortingByInsert(int[] mass, Stopwatch stopwatch, Timing timing)
        {
            stopwatch.Restart();
            for (int i = 1; i < mass.Length; i++)
            {
                int k = mass[i];
                int j = i - 1;

                while (j >= 0 && mass[j] > k)
                {
                    mass[j + 1] = mass[j];
                    mass[j] = k;
                    j--;
                }
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedTicks.ToString());

        }
    }
}
 

