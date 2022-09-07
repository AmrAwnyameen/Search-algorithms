using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
   public class JumpSearch
    {

    public static int jumpSearch(int[] arr, int target)
        {

            arr = arr.OrderBy(s => s).ToArray();
            int blockSize = (int)Math.Sqrt(arr.Length);

            int start = 0;
            int next = blockSize;
            while(start < arr.Length && arr[next -1] < target)
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
