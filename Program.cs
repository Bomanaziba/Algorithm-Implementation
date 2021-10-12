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

            List<int> arr = new List<int>
            {
                1, 2, 1, 3, 2, 3
            };

            
            var max = Hacker.Algorithms.maxPoints(arr);
   
            Console.WriteLine(max);
        }
    }
}
