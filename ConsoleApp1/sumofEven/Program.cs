using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace sumofEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[6];

            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine($"Enter number {i + 1}:");
                bool result = int.TryParse(Console.ReadLine(), out int number);
                if (result)
                {
                    intArray[i] = number;
                }
                else
                {
                    Console.WriteLine("Not a valid number");
                    i--;
                    continue;
                }
            }

            

            int sum = 0;

            foreach (int number in intArray)
            {
                Console.Write($"{number} ");
             
                if (number % 2 == 0)
                {
                    sum += number;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"The sum is {sum}.");

            Console.ReadLine();
        }
    }
    }
}
