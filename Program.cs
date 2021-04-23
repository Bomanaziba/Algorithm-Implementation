using System;
using InitialPublicOfferring;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            int[][] arr = new Int32[5][] {
                new int[] {1, 5, 5, 0}, 
                new int[] {2, 7, 8, 1}, 
                new int[] {3, 7, 5, 1}, 
                new int[] {4, 10, 3, 3},
                new int[] {5, 9, 2, 3}
            };

            int[] result = InitialPublicOfferringAlgorithm.GetUnallocattedUsers(arr, 18);

            foreach(var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
