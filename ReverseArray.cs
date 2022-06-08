


namespace Algorithms.ArrayMethod
{
    public class ReverseArray
    {
        public static T[] ReverseArrayRecursively<T>(T[] arr, int startIndex, int endingIndex)
        {
            if(startIndex >= endingIndex) return arr;

            T a = arr[startIndex];

            arr[startIndex] = arr[endingIndex];
            arr[endingIndex] = a;

            return ReverseArrayRecursively(arr, startIndex + 1, endingIndex - 1);
        }
    }
}