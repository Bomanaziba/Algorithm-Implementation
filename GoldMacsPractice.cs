using System;
using System.Collections.Generic;

namespace Hacker
{
    public class Algorithms
    {
        public static string findNumber(List<int> arr, int k)
        {

            if (arr == null || arr.Count < 1 || arr.Count > Math.Pow(10, 5)) return "NO";

            if (k < 1 || k > Math.Pow(10, 9)) return "NO";

            foreach (var item in arr)
            {
                if (k == item) return "YES";
            }

            return "NO";

        }

        public static List<int> oddNumbers(int l, int r)
        {

            if (l < 1) return null;

            if (r > Math.Pow(10, 5)) return null;

            List<int> oddList = new List<int>();

            while (l < r)
            {
                int odd = Odd(l);

                if (odd > 0)
                {
                    oddList.Add(l);
                }
                l++;
            }

            return oddList;

        }

        private static int Odd(int num)
        {
            if (num % 2 != 0)
            {
                return num;
            }
            return 0;
        }

        public static int hourglassSum(List<List<int>> arr)
        {

            if(arr == null || arr.Count < 6) return 0;

            int max = 0;

            List<int> hourGlass = getHourGlass(arr);

            for (int i = 0; i < hourGlass.Count; i++)
            {
                int tortoise = i;
                int hare = i + 1;

                if(i==0) max=hourGlass[tortoise];

                if (hare == hourGlass.Count) break;

                int maxT = hourGlass[tortoise];
                max = max>maxT?max:maxT;
                int maxH = hourGlass[hare];
                max = max>maxH?max:maxH;
            }

            return max;
        }

        private static List<int> getHourGlass(List<List<int>> arr)
        {
            int sparrow = 0;
            int pigeon = 1;
            int eagle = 2;
            int falcon = 3;

            int a = 0, b = 0, c = 0, d = 0, e = 0, f = 0, g = 0, h = 0, l = 0, o = 0, p = 0, q = 0, r = 0, s = 0, t = 0, u = 0;

            for (int i = 0; i < arr.Count; i++)
            {

                if(i<0) return null;

                if (arr[i].Count < 0 || arr[i].Count > 6) return null;

                if (falcon == arr.Count) break;

                int tortoise = 0;
                int hare = 1;
                int lion = 2;
                int cheetah = 3;

                for (int j = 0; j < arr[i].Count; j++)
                {
                    if(j>5) return null;

                    if(arr[i].Count < 6) return null;

                    if (arr[i][j] < -9 || arr[i][j] > 9) return null;

                    if (arr[i].Count == cheetah) break;

                    a += ((tortoise == 0 || tortoise == 2) && sparrow == 1)?0:arr[sparrow][tortoise];
                    b += ((hare == 1 || hare == 3) && sparrow == 1)?0:arr[sparrow][hare];
                    c += ((lion == 2 || lion == 4) && sparrow == 1)?0:arr[sparrow][lion];
                    d += ((cheetah == 3 || cheetah == 5) && sparrow == 1)?0:arr[sparrow][cheetah];

                    e += ((tortoise == 0 || tortoise == 2) && pigeon == 2)?0:arr[pigeon][tortoise];
                    f += ((hare == 1 || hare == 3) && pigeon == 2)?0:arr[pigeon][hare];
                    g += ((lion == 2 || lion == 4) && pigeon == 2)?0:arr[pigeon][lion];
                    h += ((cheetah == 3 || cheetah == 5) && pigeon == 2)?0:arr[pigeon][cheetah];

                    l += ((tortoise == 0 || tortoise == 2) && eagle == 3)?0:arr[eagle][tortoise];
                    o += ((hare == 1 || hare == 3) && eagle == 3)?0:arr[eagle][hare];
                    p += ((lion == 2 || lion == 4) && eagle == 3)?0:arr[eagle][lion];
                    q += ((cheetah == 3 || cheetah == 5) && eagle == 3)?0:arr[eagle][cheetah];

                    r += ((tortoise == 0 || tortoise == 2) && falcon == 4)?0:arr[falcon][tortoise];
                    s += ((hare == 1 || hare == 3) && falcon == 4)?0:arr[falcon][hare];
                    t += ((lion == 2 || lion == 4) && falcon == 4)?0:arr[falcon][lion];
                    u += ((cheetah == 3 || cheetah == 5) && falcon == 4)?0:arr[falcon][cheetah];

                    tortoise++;
                    hare++;
                    lion++;
                    cheetah++;
                }

                sparrow++;
                pigeon++;
                eagle++;
                falcon++;
            }

            return new List<int> { a, b, c, d, e, f, g, h, l, o, p, q, r, s, t, u };
        }
    }
}