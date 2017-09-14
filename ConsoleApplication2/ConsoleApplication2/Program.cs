using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> orderedList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> unorderedList = new List<int> { 5, 1, 3, 8, 0, 6, 9, 2, 4, 7};

            Console.WriteLine(ReturnIndexGreaterOrEqual(5, orderedList));

        }

        public static int ReturnIndexGreaterOrEqual(int value, List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] >= value)
                    Debug.Assert(list[i] >= value);
                    return i;
            }
            return list.Count;
        }

    }
}

/*
 Write a method that takes an ordered list and a value and returns the index of the location of the first element that is 
 greater than or equal to the specified value. Return the index. Provide tests to demonstrate that this method works

Next, write a method that takes a list and an index into the list. From the specified index, have the method move all the 
elements of the list up. This method effectively leaves an empty space in the list. It doesn’t matter what value the empty 
element contains. Provide tests to demonstrate that this method works.

Create a third method that takes an ordered list and a value and inserts the value at the appropriate location in the ordered 
list. Write tests to demonstrate that this method works.

Create a fourth method that creates a list of N elements with random, but ordered values. The values should be ordered but not 
sequential. Write tests that demonstrate that the list you created is ordered and not sequential.

Finally, write a program that creates ordered lists of sizes ranging from 100 to 10,000 (growing by 100 each time). 
For each of these lists, time how long it takes to insert a random number into the list. Print out the list size and the times 
and graph them as we have done in previous exercises. You do not have to turn in the graph and you do not have to write any 
tests for the program part (but you will still need to write and turn in tests for each of the methods).
     */
