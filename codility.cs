using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public static int solution(int[] A)
    {

        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int number = 1;

        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] <= number) number = A[i] + 1;
        }

        return number;
    }

    public static int solution1(int[] A)
    {

        // write your code in C# 6.0 with .NET 4.5 (Mono)

        if (A.Length <= 0 || A.Length >= 100000) return -1;

        const int Cost1dayTicket = 2;
        const int Cost7dayTicket = 7;
        const int Cost30dayTicket = 25;

        int diffInDay_s = 0;
        int _7InDay_s = 0;
        int _30InDay_s = 0;

        int previousNumber = A[0];

        int _1dayCount = 0;
        int _7DayIntervalCount = 0;
        int _30IntervalDayCount = 0;
        int _30DayCount = 0;

        int _7DayCount = 0;


        for (int i = 0; i < A.Length; i++)
        {
            diffInDay_s += (A[i] - previousNumber);

            if (_7InDay_s < 7)
            {
                _7InDay_s = diffInDay_s;
                _7DayCount++;
            }
            else
            {
                _7InDay_s = 0;
                _7DayIntervalCount++;
            }

            if (_30InDay_s < 30)
            {
                _30InDay_s = diffInDay_s;
                _30DayCount++;
            }
            else
            {
                _30InDay_s = 0;
                _30IntervalDayCount++;
            }

            _1dayCount++;

            previousNumber = A[i];
        }

        int _costOf7DayTicket = ((_7DayCount / 7 + (_7DayCount % 7 > 0 ? 1 : 0)) * Cost7dayTicket) + ((_1dayCount - _7DayCount) * Cost1dayTicket);
        int _costOf30DaysTicket = ((_30DayCount / 7 + (_30DayCount % 7 > 0 ? 1 : 0)) * Cost30dayTicket) + ((_1dayCount - _30DayCount) * Cost1dayTicket);
        int _costOf1DayTicket = (_1dayCount * Cost1dayTicket);

        if (_costOf7DayTicket < _costOf30DaysTicket && _costOf7DayTicket < _costOf1DayTicket && _costOf7DayTicket > 0) return _costOf7DayTicket;
        else if (_costOf30DaysTicket < _costOf7DayTicket && _costOf30DaysTicket < _costOf1DayTicket && _costOf30DaysTicket > 0) return _costOf30DaysTicket;
        else return _costOf1DayTicket;
    }

    public static int solution4(string S)
    {

        // write your code in C# 6.0 with .NET 4.5 (Mono)

        int ballonCount = 0;
        int bCount = 0;
        int aCount = 0;
        int lCount = 0;
        int oCount = 0;
        int nCount = 0;

        for (int i = 0; i < S.Length; i++)
        {
            switch (S[i])
            {
                case 'B':
                    if (bCount < 1) { bCount++; ballonCount++;}
                    break;
                case 'A':
                    if (aCount < 1) { aCount++; ballonCount++; }
                    break;
                case 'L':
                    if (lCount < 2) { lCount++; ballonCount++; }
                    break;
                case 'O':
                    if (oCount < 2) { oCount++; ballonCount++; }
                    break;
                case 'N':
                    if (nCount < 1) { nCount++; ballonCount++; }
                    break;
                default:
                    break;
            }
            int count = ballonCount / 7;
            if (count > 0) { bCount = 0; aCount = 0; lCount = 0; oCount = 0; nCount = 0;}
        }

        int ballonOccurred = ballonCount / 7;

        return ballonOccurred;

    }


}
