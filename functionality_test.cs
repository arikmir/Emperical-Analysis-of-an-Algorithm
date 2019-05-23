using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asssesment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            FunctionalTesting();
            Console.ReadKey();
        }

        static int Median(int[] Arr, int n, int k)
        {

            for (int i = 0; i <= n - 1; i++)
            {
                int numsmaller = 0;
                int numequal = 0;

                for (int j = 0; j <= n - 1; j++)
                {

                    if (Arr[j] < Arr[i])
                    {
                        numsmaller++;
                    }
                    else if (Arr[j] == Arr[i])
                    {
                        numequal++;
                    }
                }
                if ((numsmaller < k) && (k <= (numsmaller + numequal)))
                {
                    return Arr[i];
                }
            }
            return 0;
        }

        static void FunctionalTesting()
        {
            Console.WriteLine("FUNCTIONALITY CORRECTNESS TESTING");
            Console.WriteLine("----------------------");

            // Console.WriteLine("");
            int n = 10;
            int k = (int)Math.Ceiling(n / 2.0);

            //Array of Consecutive Numbers
            int[] consecutive_arr = new int[] { 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 };
            int consec_median = Median(consecutive_arr, n, k);
            Console.WriteLine("An array of CONSECUTIVE NUMBERS: { 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 }");
            Console.WriteLine("Median of the array is: {0}", consec_median);

            Console.WriteLine();

            //Array of Sorted Numbers
            int[] sorted_arr = new int[] { 5, 7, 11, 13, 15, 17, 20, 23, 27, 29 };
            int sorted_median = Median(sorted_arr, n, k);
            Console.WriteLine("An array of SORTED NUMBERS: { 5, 7, 11, 13, 15, 17, 20, 23, 27, 29}");
            Console.WriteLine("Median of the array is: {0}", sorted_median);

            Console.WriteLine();

            //Array of Unsorted Numbers
            int[] unsorted_arr = new int[] { 20, 23, 7, 5, 11, 15, 29, 27, 13, 17 };
            int unsorted_median = Median(unsorted_arr, n, k);
            Console.WriteLine("An array of UNSORTED NUMBERS: { 20, 23, 7, 5, 11, 15, 29, 27, 13, 17 }");
            Console.WriteLine("Median of the array is: {0}", unsorted_median);

            Console.WriteLine();

            //Array of Reverse Numbers
            int[] reverse_arr = new int[] { 29, 27, 23, 20, 17, 15, 13, 11, 7, 5 };
            int reverse_median = Median(reverse_arr, n, k);
            Console.WriteLine("An array of REVERSE NUMBERS: { 29, 27, 23, 20, 17, 15, 13, 11, 7, 5 }");
            Console.WriteLine("Median of the array is: {0}", reverse_median);

            Console.WriteLine();

            //Array of Random Numbers
            int[] random_arr = new int[] { 44, 12, 32, 22, 1, 23, 6, 49, 11, 43 };
            int random_median = Median(random_arr, n, k);
            Console.WriteLine("An array of RANODM NUMBERS: { 44, 12, 32, 22, 1, 23, 6, 49, 11, 43 }");
            Console.WriteLine("Median of the array is: {0}", random_median);

            Console.WriteLine();

            //Array of Partially Sorted Numbers
            int[] partial_arr = new int[] { 13, 15, 17, 19, 20, 45, 11, 34, 31, 14 };
            int partial_median = Median(partial_arr, n, k);
            Console.WriteLine("An array of PARTIALLY SORTED NUMBERS: { 13, 15, 17, 19, 20, 45, 11, 34, 31, 22 }");
            Console.WriteLine("Median of the array is: {0}", partial_median);

            Console.WriteLine();

            //Array of Odd Length
            int[] odd_arr = new int[] { 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32 };
            int odd_median = Median(odd_arr, 11, k);
            Console.WriteLine("An array of ODD LENGTH: { 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32 }");
            Console.WriteLine("Median of the array is: {0}", odd_median);
            Console.WriteLine();

            //Array Including Both positive and Negative Numbers
            int[] mixed_arr = new int[] { -12, 34, 54, -99, -34, -7, 89, 234, -119, 37 };
            int mixed_median = Median(mixed_arr, n, k);
            Console.WriteLine("An array of PARTIALLY SORTED NUMBERS: { -12,34,54,-99,-34,-7,89,234,-119,37}");
            Console.WriteLine("Median of the array is: {0}", mixed_median);
        }

    }
}


