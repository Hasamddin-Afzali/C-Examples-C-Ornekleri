using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Words : ");
            //Console.WriteLine("Not * ' ', ',', '.', '-', '\n', '\t'");
            string word = Console.ReadLine();
            string[] wordCounts = word.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });
            foreach(string newWords in wordCounts)
            {
                Console.WriteLine($"{newWords}");
            }
            Console.WriteLine($"Total Word Count is : {wordCounts.Length}");
            Console.ReadKey();
        }
    }
}
