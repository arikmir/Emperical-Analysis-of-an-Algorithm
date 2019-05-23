using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;


namespace execution_time
{
    class Program
    {

        static void Main(string[] args)
        {
            int totalRunningTimes = 20;
            Stopwatch sw = new Stopwatch();
            var csv = new StringBuilder();
            for (int size = 1000; size <= 20000; size += 1000)
            {
                long totalMilliSecs = 0;
                double averageMilliSecs = 0;
                for (int i = 1; i <= totalRunningTimes; i++)
                {
                    long milliSecs = 0;
                    int[] A = GenerateRandomArray(size);
                    sw.Start();
                    Median(A);
                    sw.Stop();
                    milliSecs = sw.ElapsedMilliseconds;
                    totalMilliSecs = totalMilliSecs + milliSecs;
                }

                averageMilliSecs = totalMilliSecs * 1.0 / totalRunningTimes;
                Console.WriteLine("Size: " + size + "; Average Running Time (MilliSec)= " + averageMilliSecs);
                var first = size.ToString();
                var second = averageMilliSecs.ToString();
                var newLine = string.Format("{0},{1}", first, second);
                csv.AppendLine(newLine);
            }
            File.WriteAllText(@"C:\Users\Arik\Desktop\CAB 301\intenam.csv", csv.ToString());
            Console.ReadKey();
        }

        static int[] GenerateRandomArray(int size)
        {
            int[] A = new int[size];

            int seed = (int)DateTime.Now.Ticks;
            Random rnd = new Random(seed);

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = rnd.Next(Int32.MaxValue);
            }
            return A;
        }

        static int Median(int[] A)
        {
            int n = A.Length;
            int k = n / 2;

            for (int i = 0; i <= (n - 1); i++)
            {
                int numsmaller = 0;
                int numequal = 0;

                for (int j = 0; j <= (n - 1); j++)
                {

                    if (A[j] < A[i])
                    {
                        numsmaller++;
                    }
                    else if (A[j] == A[i])
                    {
                        numequal++;
                    }
                }
                if ((numsmaller < k) && (k <= (numsmaller + numequal)))
                {
                    return A[i];
                }
            }
            return -1;

        }

    }
}
