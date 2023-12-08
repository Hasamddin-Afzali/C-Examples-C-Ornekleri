using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Is_Leap_Year
{
    internal class Program
    {
        class leapyear
        {
            static void Main(string[] args)
            {
                leapyear obj = new leapyear();
                obj.readdata();
                obj.leap();
            }
            int y;
            public void readdata()
            {
                Console.WriteLine("Enter the Year in Four Digits : ");
                y = Convert.ToInt32(Console.ReadLine());
            }
            public void leap()
            {
                if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
                {
                    Console.WriteLine("{0} is a Leap Year", y);
                }
                else
                {
                    Console.WriteLine("{0} is not a Leap Year", y);
                }
                Console.ReadLine();
            }
        }
    }
}
