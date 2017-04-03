
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBQuestions_CarreerCup
{
    public class Utilities
    {
        public static List<string> GetCartesianProduct(int length)
        {
            List<string> result = new List<string>();
            int[] firstA = new int[length];
            int[] secondA = new int[length];

            for (int i = 0; i < length; i++)
            {
                firstA[i] = i; secondA[i] = i;
            }

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (i != j)
                        if (!result.Contains(secondA[j].ToString() + "," + firstA[i].ToString()))
                            result.Add(firstA[i].ToString() + "," + secondA[j].ToString());
                }
            }
            return result;
        }

        public static void Fibonicci(int n)
        {
            int prevNumber = 0;
            int currentNumber = 1;
            while (currentNumber <= n)
            {
                Console.WriteLine(prevNumber);
                int temp = currentNumber;
                currentNumber = currentNumber + prevNumber;
                prevNumber = temp;
            }
            Console.WriteLine(prevNumber);
        }
    }
}
