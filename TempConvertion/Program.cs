using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempConvertion
{
    
    internal class Program
    {        
        static void Main(string[] args)
        {
            //Exercise 1
            CelciusToFahrenheit();
            //Exercise 2
            FahrenheitToCelcius();
            //Exercise 3
            while (true)
            {
                Console.WriteLine("Temperature Convertion \n 1. Celcius to Fahrenheit \n 2. Fahrenheit to Celcius");
                Console.WriteLine("Please select the desired conversion"); 
                char userSelection = Console.ReadKey(true).KeyChar;
                
                if (userSelection == '1')
                {
                    Console.WriteLine($"You pressed {userSelection} for Celcius to Fahrenheit");
                    CelciusToFahrenheit();
                }
                else if (userSelection == '2')
                {
                    Console.WriteLine($"You pressed {userSelection} for Fahrenheit to Celcius");
                    FahrenheitToCelcius();
                }
                else
                    Console.WriteLine("\nInvalid selection, Please try again. ");
            }
        }
        private static void CelciusToFahrenheit()
        {            
            Console.Write("Please enter a number: ");
            string userInput = Console.ReadLine();

            if (double.TryParse(userInput, out double numCelcius))
            {
                Console.WriteLine($"You entered {userInput} degrees Celcius");
                double fahrenheit = (numCelcius * 9 / 5) + 32;
                Console.WriteLine($"That is equivalent to {fahrenheit} degrees Fahrenheit\n");
            }
            else
                Console.WriteLine("Please enter a valid number");
        }
        private static void FahrenheitToCelcius()
        {
            Console.Write("Please enter a number: ");
            string userInput = Console.ReadLine();

            if (double.TryParse(userInput, out double numFahrenheit))
            {
                Console.WriteLine($"You entered {userInput} degrees Celcius");
                double celcius = (numFahrenheit - 32) * 5 / 9;
                Console.WriteLine($"That is equivalent to {celcius} degrees Celcius\n");
            }
            else
                Console.WriteLine("Please enter a valid number");
        }
    }
}
