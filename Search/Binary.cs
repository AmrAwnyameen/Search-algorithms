using System.Linq;

namespace Search
{
    public class Binary
    {
        //var numbers = new[] { 1, 8, 9, 10, 12, 40,50,60,79 };
        public static int BinarySearch(int[] arr, int traget)
        {
            arr = arr.OrderBy(s => s).ToArray();
           return BinarySearch(arr, 0, arr.Length-1, traget);
        }

        public static int BinarySearch(int[] arr, int left, int right, int target)
        {
            var middle = (left + right) / 2;

            if (right < left)
                return -1;

            if (arr[middle] == target)
                return middle;

            if (arr[middle] > target)
                return BinarySearch(arr, left, middle - 1, target);
            

            return BinarySearch(arr, middle + 1, right, target);
        }

        public int SearchInsert(int[] nums, int target)
        {
            nums = nums.OrderBy(s => s).ToArray();
            var left = 0;
            var right = nums.Length - 1;
            var middle = (left + right) / 2;

            while (right < left)
            {
                if (nums[middle] == target)
                    return middle;

                else if (nums[middle] > target)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }
          return  middle + 1;

        }
    }
}
