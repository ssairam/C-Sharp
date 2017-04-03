using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBQuestions_CarreerCup
{
    public class Node : IComparer<Node>
    {
        private int _firstSeen;
        private int _frequency;
        private int _value;

        public Node(int value, int frequency, int firstSeen)
        {
            _value = value; _frequency = frequency; _firstSeen = firstSeen;
        }

        public Node()
        {
        }

        public int Compare(Node x, Node y)
        {
            System.Diagnostics.Debug.Print("-------------------------------------------------------");
            System.Diagnostics.Debug.Print(string.Format("{0},{1},{2},{3}", x.Frequency,y.Frequency,x.FirstSeen,y.FirstSeen));
            if (x.Frequency == y.Frequency)
            {
                System.Diagnostics.Debug.Print((x.FirstSeen - y.FirstSeen).ToString());
                System.Diagnostics.Debug.Print("-------------------------------------------------------");
                return x.FirstSeen - y.FirstSeen;
            }
            System.Diagnostics.Debug.Print(((x.Frequency - y.Frequency) * 5).ToString());
            System.Diagnostics.Debug.Print("-------------------------------------------------------");
            return (x.Frequency - y.Frequency) * 5;
        }



        public int FirstSeen
        {
            get
            {
                return _firstSeen;
            }

        }

        public int Frequency
        {
            get
            {
                return _frequency;
            }
            set
            {
                _frequency = value;
            }
        }

        public int Value
        {
            get
            {
                return _value;
            }
        }
    }

}
