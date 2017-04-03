using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
    public class ArraysStrings
    {
        ///Implement an algorithm to determine if a string has all unique characters. 
        ///What if you can not use additional data structures?
        public bool StringHasUniqueCharaters(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;
            int len = s.Length;
            if (len < 2) return true;
            int tail = 1;
            char[] strs = s.ToCharArray();


            for (int i = 0; i < len; i++)
            {
                int j = 0;
                for (j = 0; j < tail; j++)
                {
                    if (strs[i] == strs[j]) return false;
                }
                tail++;
            }
            return true;
        }
    }
}
