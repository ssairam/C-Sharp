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

            Console.WriteLine("-------Hello World----------");
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