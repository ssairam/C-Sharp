using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
    public class QuickSort0
    {
        int[] _numbers = null;

        public void Sort(int[] name)
        {
            if (name == null || 0 == name.Length) return;
            _numbers = name;
            Karm(0, name.Length-1);
        }

        private void Karm(int v, int length)
        {
            int l = v, h = length;
            var pivot = _numbers[(v + length) / 2];

            while (l <= h)
            {
                while (_numbers[l] < pivot) l++;
                while (_numbers[h] > pivot) h--;

                if (l <= h)
                {
                    swap(l, h);
                    l++; h--;
                }
            }

            if (l < length) Karm(l, length);
            if (h > v) Karm(v, h);
        }

        private void swap(int l, int h)
        {
            var temp = _numbers[l];
            _numbers[l] = _numbers[h];
            _numbers[h] = temp;
        }
    }
}
