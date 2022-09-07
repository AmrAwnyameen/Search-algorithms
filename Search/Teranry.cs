using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
   public class Teranry
    {
        //var numbers = new[] { 1, 8, [mid1]9, 10, 12, 40,[mid2]50,60,79 };

        public static int TeranrySearch(int[] arr, int traget)
        {
            arr = arr.OrderBy(s => s).ToArray();
            return Teranryearch(arr, 0, arr.Length - 1, traget);
        }

        public static int Teranryearch(int[] arr, int left, int right, int target)
        {
            var partionSize = (right - left) / 3;
            var mid1 = left + partionSize;
            var mid2 = right - partionSize;

            if (right < left)
                return -1;

            if (arr[mid1] == target)
                return mid1;

            if (arr[mid2] == target)
                return mid2;


            if (target < arr[mid1])
                return Teranryearch(arr,left, mid1 -1, target);

            if (target > arr[mid2])
                return Teranryearch(arr, mid2 + 1, right, target);

            return Teranryearch(arr, mid1 + 1, mid2 -1, target);
        }
    }
}
