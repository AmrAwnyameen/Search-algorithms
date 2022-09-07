using System;

namespace Search
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 1, 40, 50, 79, 60, 9, 8, 10, 12 };

            ////linear
            //Console.WriteLine(Linear.LinearSearch(numbers, 90).ToString());

            ////Binary
            //Console.WriteLine(Binary.BinarySearch(numbers, 40).ToString());

            //Teranry
            // Console.WriteLine(Teranry.TeranrySearch(numbers, 12).ToString());

            //ExponentialSearch
            //Console.WriteLine(Exponential.ExponentialSearch(numbers, 12).ToString()); 

            //JupmSearch
            Console.WriteLine(JumpSearch.jumpSearch(numbers, 60).ToString()); 


            Console.ReadLine();

        }

    }
}
