using System;

namespace Algos
{
    public class QuickSort
    {

        private int[] _numbers = null;
        internal void Sort(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return;
            _numbers = numbers;

            DivideAndSort(0, numbers.Length - 1);
        }

        private void DivideAndSort(int lower, int upper)
        {

            int l = lower, u = upper;
            var p = (lower + upper) / 2;
            var pivot = _numbers[p];

            while (l <= u)
            {
                while (_numbers[l] < pivot) l++;
                while (_numbers[u] > pivot) u--;

                if (l <= u)
                {
                    swap(l, u);
                    l++;u--;
                }
            }

            if (l < upper) DivideAndSort(l, upper);
            if (u > lower) DivideAndSort(lower, u);

        }

        private void swap(int l, int u)
        {
            int temp = _numbers[l];
            _numbers[l] = _numbers[u];
            _numbers[u] = temp;
        }
    }
}