using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBQuestions_CarreerCup
{

    public class StringManipulations
    {

        public void ReplaceCharsInStrWithTheirNumberOfOccurences()
        {
            var input = Console.ReadLine();
            char[] ca = input.ToCharArray();
            Dictionary<char, int> results = new Dictionary<char, int>();
            foreach (char s in ca)
            {
                if (!results.Keys.Contains<char>(s))
                    results.Add(s, 1);
                else
                    results[s]++;

            }
            string solution = string.Empty;
            foreach (var k in results.Keys)
            {
                solution += results[k].ToString() + k.ToString();
            }
            Console.WriteLine(solution);
        }
    }
}
