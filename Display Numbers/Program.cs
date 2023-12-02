using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number That you want to get the display form 0 to That Number");
            bool isNumber = false;
            while (!isNumber)
            {
                try
                {
                    int number = Convert.ToInt32(Console.ReadLine());
                    if (number == 0)
                    {
                        Console.WriteLine("Zero !");
                    }else if(number < 0)
                    {
                        for (int i = 0; i >= number; i--)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    else
                    {
                        for (int i = 0; i <= number; i++)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    isNumber = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please Enter a Number !");
                    isNumber = false;
                }
            }
            Console.ReadKey();
        }
    }
}
