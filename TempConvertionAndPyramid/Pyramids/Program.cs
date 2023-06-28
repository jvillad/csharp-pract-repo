using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramids
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Please enter a number: ");
                string userInput = Console.ReadLine();

                if (!int.TryParse(userInput, out int numOfStars)) 
                {
                    Console.WriteLine("Invalid number, Try again.");
                }                                               
                else
                {
                    for (int i = 1; i <= numOfStars; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    for (int i = numOfStars; i > i * -1; i--)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    for (int i = numOfStars; i > i * -1; i--)
                    {
                        for (int j = i; j < numOfStars; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int k = 1; k <= i; k++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    for (int i = 1; i <= numOfStars; i++)
                    {
                        for (int j = i; j < numOfStars; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int k = 1; k <= i; k++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();

                }
               
            }
            

        }
    }
}
