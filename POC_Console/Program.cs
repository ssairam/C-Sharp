using System;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Algos;
using BBQuestions_CarreerCup;
using System.Threading.Tasks;
using System.Text;
using MultiThreading;

namespace POC_Console
{
    delegate void DisplayMessage(string message);

    class Solution
    {
        /// <summary>
        /// Return single digit to a three digit number
        /// </summary>
        /// <param name="args"></param>
        static void Main(String[] args)
        {
            var numbers = new int[5] { 1,2,3,4,5};

            var results = numbers.OrderByDescending(x => x);
            var length = results.Count();

            for (int i = 0; i < 3;i++)
                Console.WriteLine(results.ElementAt(i));
            
            Console.ReadLine();
        }

        static int f(int i)
        {
            if (i.ToString().Length == 1) return i;
            var numbers = i.ToString().ToCharArray();
            var result = 0;
            foreach (var n in numbers)
            {
                result += Convert.ToInt32(n.ToString());
            }
            return f(result);
        }
    }
}