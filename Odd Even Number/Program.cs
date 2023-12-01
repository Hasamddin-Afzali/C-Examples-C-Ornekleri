using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Number : ");
            
            bool isNumber = false;
            int number = 0;

            while (!isNumber)
            {
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    isNumber = true;
                }catch (FormatException)
                {
                    isNumber = false;
                    Console.WriteLine("Please Enter A number !");
                }
            }
            if(number %2 == 0)
            {
                Console.WriteLine("The Number is Even !");
            }
            else
            {
                Console.WriteLine("The Number is Even Odd !");
            }
            Console.ReadKey();

        }
    }
}
