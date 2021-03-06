using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Sort
{
    public class SortAlgorithm
    {

        public static List<int> MergeSortRecursive(List<int> unsorted)
        {
            if(unsorted.Count <= 1)
                return unsorted;

            List<int> left = new List<int>();

            List<int> right = new List<int>();

            int middle = unsorted.Count/2;

            for(int i = 0; i < middle; i++)
            {
                left.Add(unsorted[i]);
            }

            for(int i = middle; i < unsorted.Count(); i++)
            {
                right.Add(unsorted[i]);
            }

            left = MergeSortRecursive(left);
            right = MergeSortRecursive(right);

            return Merge(left, right);
        }

        private static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while(left.Count > 0 || right.Count > 0)
            {
                if(left.Count > 0 && right.Count > 0)
                {
                    if(left.First() <= right.First())
                    {
                        result.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }

            return result;
        }
    
        
    
    }
}