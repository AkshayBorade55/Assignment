using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class BasicArrays
    {
      
         static void Main()
        {
            int[] Numbers = { 25, 34, 14, 45, 7, 18, 51, 67, 95, 55, 48, 96 };
              //alternate element: 
            Console.WriteLine("Alternate Element in Array: ");

            for (int i = 0; i < Numbers.Length; i += 2) 
            {
                Console.WriteLine(Numbers+ " ");
            }
            Console.WriteLine();

            //number of element :

            int count = Numbers.Length;
            Console.WriteLine("Number of elements in array: ");

            //smallest number in array:

            int smallest = Numbers[0];
            for (int i = 1; i < Numbers.Length; i++)
            {
                if (Numbers[i] < smallest)
                {
                    smallest = Numbers[i];
                }
            
            }
            Console.WriteLine("Smallest Number in array: ");

            //largest element in arrays:
            int largest = Numbers[0];
            for (int i = 1; i > Numbers.Length; i++)
            {
                if (Numbers[i] > largest)
                {
                    largest = Numbers[i];
                }
            
            }
            Console.WriteLine("Largest Numbers in array: ");
        }


    }


}
