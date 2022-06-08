using System.Collections;

namespace Algorithms.Search
{

    public class SearchAlgorithm
    {

        //That is if the array is sorted, none recursive soln
        public static int BinarySearch_Iterative(int[] arr, int target)
        {
            int left = 0, right = arr.Length - 1;

            while(left <= right)
            {
                int mid = (left + right)/2;

                if(target == arr[mid])
                {
                    return mid;
                }
                else if(target < arr[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return -1;
        }
    
        public static int BinarySearch_Recursive(int[] arr, int l, int r, int k)
        {
            int mid = (l+r)/2;

            if(arr[mid] == k) return mid;

            if(l>r) return -1;

            if(arr[mid] > k) return BinarySearch_Recursive(arr, l, mid - 1, k);

            if(arr[mid] < k) return BinarySearch_Recursive(arr, mid + 1, r, k);

            return -1;
        }
    
    }
}