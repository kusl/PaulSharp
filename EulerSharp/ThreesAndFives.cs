//Multiples of 3 and 5
//Problem 1
//If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

//Find the sum of all the multiples of 3 or 5 below 1000.
namespace EulerSharp
{
    public class ThreesAndFives
    {
        private static System.Collections.Generic.List<int> list_of_multiples_of_number_below_int(int number_to_multiple, int below_integer)
        {
            var my_list = new System.Collections.Generic.List<int>();
            for (int i = 0; i < below_integer; i++)
            {
                if (i % number_to_multiple == 0)
                {
                    my_list.Add(i);
                }
            }
            return my_list;
        }
        public static int sum_of_list(int number_to_multiple, int below_integer)
        {
            System.Collections.Generic.List<int> input_list = list_of_multiples_of_number_below_int(number_to_multiple, below_integer);
            var accumulator = 0;
            foreach(int i in input_list)
            {
                accumulator += i;
            }
            return accumulator;
        }
        public static int find_sum(int below_integer)
        {
            return 0;
        }
    }
}
