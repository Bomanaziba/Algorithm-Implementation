namespace Algorithms.Series
{


    public class FibonacciSeries
    {
        public static long FibonacciRecursive(int n)
        {
            switch (n)
            {
                case 0:
                    return 0;
                case 1:
                    return 1;
                default:
                    return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
            }
        }

        public static long FibonacciNonRecursive(int n)
        {
            int firstNumber = 0, secondNumber = 1, result = 0;

            switch (n)
            {
                case 0:
                    return 0;
                case 1:
                    return 1;
                default:
                    for(int i = 2; i <= n; i++)
                    {
                        result = firstNumber + secondNumber;
                        firstNumber = secondNumber;
                        secondNumber = result;
                    }
                    return result;
            }
        }
    }

    
}