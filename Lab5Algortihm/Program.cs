using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Algortihm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {32, 44, 69, 86, 72};

            Console.WriteLine("Before: ");
            Console.WriteLine("Array:" + string.Join(", ", numbers));
            Console.WriteLine();

            int min = numbers[0];
            int max = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }

                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine("After: ");
            Console.WriteLine("Array: " + string.Join(", ", numbers));
            Console.WriteLine("Minimum value: " + min);
            Console.WriteLine("Maximum value: " + max);
        }
    }
}
