using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
   public class JumpSearch
    {
        //      int[] arr = { 0, 1, 1, 2, 3, 5, 8, 13, 21,
                    //34, 55, 89, 144, 233, 377, 610};

    public static int jumpSearch(int[] arr, int target)
        {
            int blockSize = (int)Math.Sqrt(arr.Length);

            int start = 0;
            int next = blockSize;
            while( start < arr.Length && arr[next -1] < target)
            {
                start = next;
                next+= blockSize;
                if (next > arr.Length)
                    next = arr.Length;

            }

            for (int i = start; i < next; i++)
            {
                if (arr[i] == target)
                    return i;

                
            }

            return -1;
        }
    }
}
