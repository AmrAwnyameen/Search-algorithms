using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
   public static class Linear
    {
        public static int LinearSearch(int [] arr, int traget)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == traget)
                    return i;
            }
            return -1;
        }
    }
}
