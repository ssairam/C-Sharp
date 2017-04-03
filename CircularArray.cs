using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
    public class CircularArray
    {/*
        THIS IS WRONG. NEEDS TO BE FIXED AND I AM ANNOYED............
        */
        public void Run()
        {
            Console.SetIn(new StreamReader(Console.OpenStandardInput(80192)));

            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            int q = Convert.ToInt32(tokens_n[2]);
            //string[] a_temp = Console.ReadLine().Split(' ');
            string[] a_temp = ReadFile().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            var rot = k % n;

            if (n < 1 || n > Math.Pow(10, 5)) throw new Exception("Invalid Number");
            if (k < 1 || k > Math.Pow(10, 5)) throw new Exception("Invalid Number");
            if (q < 1 || q > 500) throw new Exception("Invalid Number");

            var output = new int[q];
            for (int a0 = 0; a0 < q; a0++)
            {
                output[a0] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (var v in output)
            {
                int index;
                if (v - rot >= 0)
                    index = n - k;
                else
                    index = n - k + v;
                if (index > n - 1) index = index % (n);
                Console.WriteLine(a[index]);
            }
        }

        public string ReadFile()
        {
            StreamReader sr = new StreamReader(@"C:\Temp\test.txt");
            return sr.ReadLine();

        }
    }
}
