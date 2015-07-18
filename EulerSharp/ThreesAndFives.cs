//Multiples of 3 and 5
//Problem 1
//If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

//Find the sum of all the multiples of 3 or 5 below 1000.
namespace EulerSharp
{
    public class ThreesAndFives
    {
        private static System.Collections.Generic.HashSet<int> list_multiples_of_number_below_int(int number_to_multiple, int below_integer)
        {
            var my_hashset = new System.Collections.Generic.HashSet<int>();
            for (int i = 0; i < below_integer; i++)
            {
                if (i % number_to_multiple == 0)
                {
                    my_hashset.Add(i);
                }
            }
            return my_hashset;
        }
        private static int sum_of_set(System.Collections.Generic.HashSet<int> input_set)
        {
            var accumulator = 0;
            foreach(int i in input_set)
            {
                accumulator += i;
            }
            return accumulator;
        }
        public static int find_sum(int below_integer)
        {
            var threes = list_multiples_of_number_below_int(3, below_integer);
            var fives = list_multiples_of_number_below_int(5, below_integer);
            threes.UnionWith(fives);
            return sum_of_set(threes);

        }
    }
}
