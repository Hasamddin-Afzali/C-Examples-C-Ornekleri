using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celsius_to_Fahrenheit_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isNumber = false;
            float Celsius = 0, result;
            Console.WriteLine("Please enter the Celsius : ");
            
            while (!isNumber) 
            {
                try
                {
                    Celsius = float.Parse(Console.ReadLine());
                    isNumber = true;
                }catch (FormatException)
                {
                    isNumber = false;
                    Console.WriteLine("Please enter a number ");
                }
            }
            result = (Celsius * 9 / 5) + 32;
            Console.WriteLine($"{Celsius} Celsius is {result} Fahrenheit");
            Console.ReadKey();
        }
    }
}
