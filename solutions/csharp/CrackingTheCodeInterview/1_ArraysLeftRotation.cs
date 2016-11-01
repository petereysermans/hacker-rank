using System;

namespace HackerRank
{
    class Solution 
    {
        static void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            int[] result = a;

            for (var i = 0; i < k; i++)
            {
                var firstElement = result[0];
                Array.Copy(result, 1, result, 0, n-1);
                result[result.Length - 1] = firstElement;
            }

            Console.WriteLine(string.Join(" ", result));
            Console.ReadLine();
        }
    }
}
