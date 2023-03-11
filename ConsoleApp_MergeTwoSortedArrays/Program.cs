using System;
using System.Text;

namespace ConsoleApp_MergeTwoSortedArrays
{
    class Program
    {
        //Function to merge two sorted arrays X[] and Y[]
        public static int[] MergeTwoArrays(int[] X, int[] Y)
        {
            int k = 0, i = 0, j = 0;
            int[] aux = new int[X.Length + Y.Length];

            // Function there are elements in the first and second arrays
            while (i < X.Length && j < Y.Length)
            {
                if (X[i] <= Y[j])
                {
                    aux[k++] = X[i++];
                }
                else
                {
                    aux[k++] = Y[j++];
                }
            }

            // copy remaining elements
            while (i < X.Length)
            {
                aux[k++] = X[i++];
            }

            while (j < Y.Length)
            {
                aux[k++] = Y[j++];
            }

            return aux;
        }

        static void Main(string[] args)
        {
            int[] X = new int[] { 1, 4, 7, 8, 10 };
            int[] Y = new int[] { 2, 3, 9 };

            int[] aux = MergeTwoArrays(X, Y);

            Console.WriteLine(String.Join(",", X));
            Console.WriteLine(String.Join(",", Y));
            Console.WriteLine(String.Join(",", aux));

            Console.ReadKey();
        }
    }
}