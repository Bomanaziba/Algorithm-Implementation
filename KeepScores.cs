
using System.Collections.Generic;

namespace Algorithms
{
    public class KeepScores
    {

        public static int LuckyNumber(int[] arr)
        {
            int result = -1;

            var luckTable = new Dictionary<int, int>();

            for(int i = 0; i < arr.Length; i++)
            {
                if(luckTable.TryGetValue(arr[i], out int number))
                {
                    number++;
                    luckTable.Remove(arr[i]);
                    luckTable.Add(arr[i], number);
                }
                else
                {
                    luckTable.Add(arr[i], 1);
                }
            }

            foreach(var item in luckTable)
            {
                if(item.Key == item.Value)
                {
                    if(result < item.Key)
                    {
                        result = item.Key;
                    }
                }
            }
            return result;
        }

        public static bool IsValid(string s)
        {
            if(s.Length <= 0) return false;

            int brachetCount = 0;
            int curlyBrachetCount = 0;
            int squareBrachetCount = 0;

            for(int j = 0; j < s.Length; j++)
            {
                var check = s[j];
                switch(check)
                {
                    case '(' or ')':
                        brachetCount++;
                        break;
                    case '{' or '}':
                        curlyBrachetCount++;
                        break;
                    case '[' or ']':
                        squareBrachetCount++;
                        break;
                    default:
                        break;
                }
            }

            if(brachetCount%2 == 0 && curlyBrachetCount%2 == 0 && squareBrachetCount%2 == 0) return true;

            return false;
        }

        public static int CalPoints(string[] ops)
        {
            if(ops ==null || ops.Length < 1) return 0;

            List<int> scores = new List<int>();

            for(int i = 0; i < ops.Length; i++)
            {
                switch(ops[i])
                {
                    case "+":
                        if(scores.Count - 1 > -1 && scores.Count - 2 > -1)
                        {
                            var add = scores[scores.Count-1] + scores[scores.Count-2];
                            scores.Add(add);
                        }
                        break;
                    case "C":
                        if(scores.Count - 1 > -1) scores.Remove(scores[scores.Count-1]);
                        break;
                    case "D":
                        if(scores.Count - 1 > -1) scores.Add(scores[scores.Count-1] * 2);
                        break;
                    default:
                        if(int.TryParse(ops[i], out int intergerValue))
                        {
                            scores.Add(intergerValue);
                        }
                        break;
                }
            }
        
            return Sum(scores);
        }

        public static int Sum(List<int> scores)
        {
            int sum = 0;
            foreach(var score in scores)
            {
                sum+=score;
            }
            return sum;
        }

    }
    
}