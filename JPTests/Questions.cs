using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algos;

namespace JPTests
{
    public class Questions
    {
        /// <summary>
        /// if two strings are provided eg cricketfield and footballfield - the greates suffix is field.
        /// if two strings are provided eg warren and buffet the greatest suffix will be NULL
        /// </summary>
        /// <param name="firstVal"></param>
        /// <param name="secondVal"></param>
        /// <returns></returns>
        public string FindGreatestSuffix(string firstVal, string secondVal)
        {
            if (string.IsNullOrEmpty(firstVal) || string.IsNullOrEmpty(secondVal)) return string.Empty;
            var lowestLength = Math.Min(firstVal.Length, secondVal.Length);

            var firstArr = firstVal.ToCharArray(); var secondArr = secondVal.ToCharArray();
            var sb = new StringBuilder(lowestLength);

            for (int i = 0; i < lowestLength; i++)
            {
                var fv = RetrieveReverseVals(firstArr, i);
                var sv = RetrieveReverseVals(secondArr, i);

                if (fv == sv)
                {
                    sb.Append(fv);
                    continue;
                }
                break;
            }
            if (sb.Length > 0)
                return StringAlgos.ReverseString(sb.ToString());
            else
                return "NULL";
        }

        private string RetrieveReverseVals(char[] arr, int i)
        {
            return arr[arr.Length - 1 - i].ToString();
        }

        /// <summary>
        /// For each consecutive even numbers and odd numbers insert a delimiter. for even insert * and for odd -
        /// 0 is neither odd or even.
        /// eg 122456087 will be 12*2*456087
        /// eg 123546067 will be 123-54*6067
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public string InsertDelimitersForEvenAndOddNumbers(string number)
        {
            if (string.IsNullOrEmpty(number)) return string.Empty;
            var arr = number.ToCharArray();
            var sb = new StringBuilder(number.Length);

            for (int i = 0; i < arr.Length - 1; i++)
            {
                var firstTime = i == 0;
                sb.Append(VerifyAndReturnStringForOddEven(arr[i], arr[i + 1], firstTime));
            }
            return sb.ToString();
        }

        /// <summary>
        /// first tim return adjacent numbers and after that return the last number.
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        private string VerifyAndReturnStringForOddEven(char v1, char v2, bool firstTime)
        {
            if (firstTime)
            {
                if (IsEven(v1, v2))
                    return v1.ToString() + "*" + v2.ToString();
                else if (IsOdd(v1, v2))
                    return v1.ToString() + "-" + v2.ToString();
                else
                    return v1.ToString() + v2.ToString();
            }
            else
            {
                if (IsEven(v1, v2))
                    return "*" + v2.ToString();
                else if (IsOdd(v1, v2))
                    return "-" + v2.ToString();
                else
                    return v2.ToString();
            }
        }

        private bool IsEven(char v1, char v2)
        {
            int fn = Convert.ToInt32(v1.ToString()); int sn = Convert.ToInt32(v2.ToString());
            if (fn == 0 || sn == 0) return false;
            if (fn % 2 == 0 && sn % 2 == 0)
                return true;
            return false;
        }
        private bool IsOdd(char v1, char v2)
        {
            int fn = Convert.ToInt32(v1.ToString()); int sn = Convert.ToInt32(v2.ToString());
            if (fn == 0 || sn == 0) return false;

            if (fn % 2 == 1 && sn % 2 == 1)
                return true;
            return false;
        }
    }
}
