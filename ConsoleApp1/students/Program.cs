using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace students
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] G1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
                string[] G2 = { "aaaaa", "vvvvv", "bbbbbb", "cccccc", "ddddddd" };

                Console.WriteLine("Enter number: (1 or 2)");
                bool result = int.TryParse(Console.ReadLine(), out int number);

                if (result)
                {
                    if (number == 1)
                    {
                        Console.WriteLine("The Students in G1 are:  ");
                        foreach (string name in G1)
                        {
                            Console.WriteLine(name);
                            
                        }
                    }
                    else if (number == 2)
                    {
                        Console.WriteLine("The Students in G2 are:  ");
                        foreach (string name in G2)
                        {
                            Console.WriteLine(name);
                           
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entered wrong number");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Entered invalid input");
                    continue;
                }
            }
        }
    }
    }
}
