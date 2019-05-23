using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brute_force_median_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Median(A);
            Console.WriteLine(Median(A));
        }

        public static int Median(int[] A)
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

                        numsmaller = numsmaller + 1;
                    }
                    else if (A[j] == A[i])
                    {

                        numequal = numequal + 1;
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
