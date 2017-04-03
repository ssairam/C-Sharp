using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgosTests
{
    public class Palindrome
    {
        static string FindBiggestPalindrome(string s)
        {
            List<string> results = new List<string>();
            var l = s.Length;

            for (int i = 0; i < l; i++)
            {
                var ss = s.Substring(i, l - i);
                if (IsPalindrome(ss)) results.Add(ss);
            }
            var maxLength = results.Max(v => v.Length);
            var r = from rs in results
                    where rs.Length == maxLength
                    select rs;
            return r.FirstOrDefault();
        }

        private static bool IsPalindrome(string s)
        {
            var la = s.ToCharArray();
            var upperLimit = la.Length - 1;
            for (int i = 0; i < s.Length; i++)
            {
                if (la[i] != la[upperLimit]) return false;
                upperLimit--;
            }
            return true;
        }
    }
}
