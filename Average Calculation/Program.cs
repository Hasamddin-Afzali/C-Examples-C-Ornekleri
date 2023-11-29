using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_Calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--------------Average of Studdent--------------
            double mid, final, average;
            Console.WriteLine("Enter Your Midterm Mark: ");
            do
            {
                mid = int.Parse(Console.ReadLine());
                if (mid < 0 || mid > 100)
                {
                    Console.WriteLine("Please enter an exam score between 0 and 100 !");
                }
            }
            while (mid < 0 || mid > 100);



            Console.WriteLine("Enter Your Final Mark: ");
            do
            {
                final = int.Parse(Console.ReadLine());
                if (final < 0 || final > 100)
                {
                    Console.WriteLine("Please enter an exam score between 0 and 100 !");
                }
            }
            while (final < 0 || final > 100);

            average = mid * 0.4 + final * 0.6;

            Console.WriteLine("Your midterm Mark is : {0} Your Final Mark is : {1} Your Average is {2}", mid, final, average);
            Console.ReadKey();
        }
    }
}
