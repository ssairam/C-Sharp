using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
    public class StringAlgos
    {
        /// <summary>
        /// Convert the string to an array. apply divide and conquer 
        /// and swap for a o(log(n)) performance and space.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ReverseString(string s)
        {
            if (String.IsNullOrEmpty(s)) return s;
            var e = s.Length; var t = new char();

            var a = s.ToCharArray();
            //Cost is o(log(n))
            //swap extremes and then keep increasing the 
            //start count and decrementing end length
            for (int i = 0; i < e; i++)
            {
                if (i == e) break;//for odd numbers - central values no action needed
                t = a[i];
                a[i] = a[e - 1];
                a[e - 1] = t;
                e = e - 1;
            }
            String result = new string(a);
            return result;
        }
    }
}
