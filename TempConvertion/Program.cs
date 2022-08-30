using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempConvertion
{
    
    internal class Program
    {        
        static void Main()
        {
            //Exercise 1
            CelciusToFahrenheit(UserInput());
            //Exercise 2
            FahrenheitToCelcius(UserInput());
            //Exercise 3
            while (true)
            {
                Console.WriteLine("Temperature Convertion \n 1. Celcius to Fahrenheit \n 2. Fahrenheit to Celcius");
                Console.WriteLine("Please select the desired conversion"); 
                char userSelection = Console.ReadKey(false).KeyChar;
                if (userSelection != '1' && userSelection != '2')
                {
                    Console.WriteLine("\nInvalid selection, Please try again");                    
                }
                else if (userSelection == '1')
                {
                    Console.WriteLine();
                    CelciusToFahrenheit(UserInput());
                }
                else if( userSelection == '2')
                {
                    Console.WriteLine();
                    FahrenheitToCelcius(UserInput());
                }
            }
        }

        private static double UserInput() 
        {
            Console.Write("Please enter a number: ");
            string userInput = Console.ReadLine();
            double numCelcius = InputValidation(userInput);
            return numCelcius;            
         
        }

        private static double InputValidation(string userInput) 
        {
            if (!double.TryParse(userInput, out double numToConvert))
            {
                Console.WriteLine("Please enter a valid number");
                UserInput();               
            }

            return numToConvert;
        }

        private static void CelciusToFahrenheit(double numCelcius)
        {            
                double fahrenheit = (numCelcius * 9 / 5) + 32;
                Console.WriteLine($"That is equivalent to {fahrenheit} degrees Fahrenheit\n");
          
        }
        private static void FahrenheitToCelcius(double numFahrenheit)
        {
            
                double celcius = (numFahrenheit - 32) * 5 / 9;
                Console.WriteLine($"That is equivalent to {celcius} degrees Celcius\n");
    
        }
    }
}
