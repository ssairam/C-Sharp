using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Algos
{

    /* 
    f(s) = |S| x NumberOfTimesSOccurs in T

    Input Format 
A single line containing string  in small letter('a' - 'z').

Output Format 
An integer containing the value of output.

Constraints 

Sample Input #00

aaaaaa
Sample Output #00

12
Explanation #00

f('a') = 6
f('aa') = 10
f('aaa') = 12
f('aaaa') = 12
f('aaaaa') = 10
f('aaaaaa') = 6
        */
    public class StringFunctionCalculation
    {

        public void Run()
        {
            //var input = Console.ReadLine();
            var input = ReadFile();
            var substrings = GetSubStrings(input);
            var len = substrings.Count();
            int[] funcResults = new int[len];
            for (int i = 0; i < len; i++)
            {
                funcResults[i] = substrings[i].Length * GetPermutations(substrings[i], input);
            }
            Console.WriteLine(funcResults.Max());
        }

        private int GetPermutations(string v, string input)
        {
            //if (v.Length == input.Length) return 1;
            //return input.Length - v.Length + 1;
            List<string> result = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {

                var counter = v.Length;
                var ub = input.Length;
                if (ub >= i + counter)
                {
                    if (v == input.Substring(i, counter))
                        result.Add(input.Substring(i, counter));
                }
            }
            return result.Count();
        }

        private List<string> GetSubStrings(string input)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                result.Add(input.Substring(0, i + 1));
            }
            return result;
        }

        public static string ReadFile()
        {
            string[] lines = File.ReadAllLines(@"c:\temp\test1.txt");
            return lines[0];
        }
    }
}
