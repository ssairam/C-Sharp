using System;

namespace Algos
{
    internal class SelectionSort
    {

        int[] _numbers = null;

        public void Sort(int[] name)
        {
            if (name == null || 0 == name.Length) return;
            _numbers = name;
            Karm(0, name.Length - 1);
        }

        private void Karm(int low, int upper)
        {
        }


        private bool isSmallest(int value, int startCounter)
        {
            return false;
        }

        private void swap(int l, int h)
        {
            var temp = _numbers[l];
            _numbers[l] = _numbers[h];
            _numbers[h] = temp;
        }
    }
}