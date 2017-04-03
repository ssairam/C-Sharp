using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBQuestions_CarreerCup
{
    /*
    Sort elements by frequency, print the elements of an array in the decreasing frequency 
    if 2 numbers have same frequency then print the one which came first.
    */
    public class HashLogic
    {
        private Dictionary<int, Node> _kv = new Dictionary<int, Node>();
        public void Run()
        {
            var input = Console.ReadLine().Split(',');
            int[] numbers = Array.ConvertAll(input, new Converter<string, int>(x => Convert.ToInt32(x)));
            int firstSeen = 0;
            foreach (var n in numbers)
            {
                if (_kv.Keys.Contains(n))
                    _kv[n].Frequency++;
                else
                {
                    _kv.Add(n, new Node(n, 1, firstSeen));
                    firstSeen++;
                }
            }

            var nodelist = _kv.Values.ToList<Node>();

            Console.WriteLine("-----------");

            foreach (var k in nodelist)
                Console.WriteLine(k.Value);

            Console.WriteLine("-----------");
            nodelist.Sort(new Node());
            foreach (var k in nodelist)
                Console.WriteLine(k.Value);


            Console.WriteLine("-----------");
            nodelist.OrderByDescending(x => x.Frequency)
                    .ThenBy(x => x.FirstSeen);

            foreach (var k in nodelist)
                Console.WriteLine(k.Value);


            Console.ReadLine();
        }
    }
}
