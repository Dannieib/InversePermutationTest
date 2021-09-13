using System;

namespace InversePermutationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 4, 5, 1 };
            var resp = InversePermutation(arr, 5);
            var output = String.Join(" ", resp);

            Console.WriteLine(output);
            Console.ReadKey();
        }

        public static int[] InversePermutation(int[] arrNum, int output)
        {
            int[] brr = new int[output];

            for (int i = 0; i < output; i++)
            {
                int pridx = arrNum[i] - 1;
                brr[pridx] = i + 1;
            }

            for (int i = 0; i < output; i++)
            {
                if (arrNum[i] != brr[i])
                {
                    return brr;
                }
            }
            return brr;
        }
    }
}
