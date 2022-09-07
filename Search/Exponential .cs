using System;
using System.Linq;

namespace Search
{
    public class Exponential
    {
        // var numbers = new[] { 1, 40, 50, 79, 60, 9 ,8, 10 ,12};
        public static int ExponentialSearch(int[] arr, int target)
        {
            arr = arr.OrderBy(s => s).ToArray();
            int bound = 1;
            while (bound < arr.Length && arr[bound] < target) 
            bound*= 2;

            var left = bound /2;
            var right = Math.Min(bound, arr.Length - 1);

            return Binary.BinarySearch(arr, left, right, target);
        }

       
    }
}
