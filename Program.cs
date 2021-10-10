using System;
using System.Collections.Generic;
using InitialPublicOfferring;
using RomanNum;
using StringCalculator;

namespace Algorithms
{
    class Program
    {
        private static object StringCalc;

        static void Main(string[] args)
        {

            List<List<int>> arr = new List<List<int>>
            {
                new List<int> { 3, 7, -3, 0, 1, 8},
                new List<int> { 1, -4, -7, -8, -6, 5},
                new List<int> { -8, 1, 3, 3, 5, 7},
                new List<int> { -2, 4, 3, 1, 2, 7},
                new List<int> { 2, 4, -5, 1, 8, 4},
                new List<int> { 5, -7, 6, 5, 2, 8}
            };

            
            var max = Hacker.Algorithms.hourglassSum(arr);
   
            Console.WriteLine(max);
        }
    }
}
