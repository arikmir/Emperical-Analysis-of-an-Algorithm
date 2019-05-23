using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace basic_operations
{
    class Program
    {

        static void Main(string[] args)
        {
            int noOfRuns = 20;
            var csv = new StringBuilder();
            for (int size = 1000; size <= 20000; size += 1000)
            {

                long totalCounts = 0;
                double averageCount = 0;
                for (int i = 1; i <= noOfRuns; i++)
                {
                    int[] X = GenerateRandomArray(size);
                    int count = Median(X);
                    totalCounts = totalCounts + count;

                    averageCount = totalCounts * 1.0 / noOfRuns;

                }

                Console.WriteLine("Size = " + size + "; Average Count = " + averageCount);


                var first = size.ToString();
                var second = averageCount.ToString();

                var newLine = string.Format("{0},{1}", first, second);
                csv.AppendLine(newLine);

            }

            File.WriteAllText(@"C:\Users\Arik\Desktop\CAB 301\Assesment 1\basic_operations.csv", csv.ToString());
            Console.ReadKey();
        }
        // C:\Users\Arik\Desktop\CAB 301\Assesment 1

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



        static double MinDistance(int[] A)
        {
            count = 0;
            int n = A.Length;
            double dmin = Double.PositiveInfinity;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    // count = count + 1;
                    if ((Math.Abs((A[i] - A[j])) < dmin) && ++count > 0)
                    {

                        dmin = Math.Abs((A[i] - A[j]));
                    }
                }
            }

            return dmin;
        }

    }
}
