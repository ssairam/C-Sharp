using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
    public class SortAlgorithms
    {
        public void BubbleSort(char[] vals)
        {
            if (null == vals) return;
            // start from the left and compare each of the array item with the immediate next on the right.
            // Compare the two values
            // Place the greater one on the right.
            //Move onto comparing the immediate right with the next right.
            bool swapPerformed = true;

            while (swapPerformed)
            {
                swapPerformed = false;
                for (int i = 0; i < vals.Length - 1; i++)
                {
                    if (vals[i] > vals[i + 1])
                    {
                        var t = vals[i];
                        vals[i] = vals[i + 1]; vals[i + 1] = t;
                        swapPerformed = true;
                    }
                }
            }
        }

        public void InsertionSort(char[] vals)
        {
            if (null == vals) return;
            /*
                start from the left and move right. assume everything in the left is sorted and right is unsorted
            */
            var tempArray = new char[vals.Length];

            for (int i = 0; i < vals.Length - 1; i++)
            {
                //loop left to right ensure left side is sorted.


            }
        }

        private int[] _numbers = null;

        public void Quicksort(int[] name)
        {
            if (null == name || 0 == name.Length) return;
            _numbers = name;

            Partition(0, name.Length - 1);
        }

        private void Partition(int lowerIndex, int higherIndex)
        {
            //get counters
            int l = lowerIndex, h = higherIndex;
            //get pivot values
            var pivot = _numbers[(lowerIndex + higherIndex) / 2];

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

            if (l < higherIndex) Partition(l, higherIndex);
            if (h > lowerIndex) Partition(lowerIndex, h);
        }


        private void swap(int i, int j)
        {
            int temp = _numbers[i];
            _numbers[i] = _numbers[j];
            _numbers[j] = temp;
        }


        public void SelectionSort(char?[] vals)
        {
            var newSort = new char?[vals.Length];
            var counter = 0;

            for (int i = 0; i < vals.Length; i++)
            {
                var hasGreaeter = false;
                if (null == vals[i]) continue;

                for (int j = i + 1; j < vals.Length; j++)
                {
                    if (vals[i] > vals[j])
                    {
                        hasGreaeter = true;
                        break;
                    }
                }
                if (!hasGreaeter)
                {
                    //Find dupes and apppend to newsort
                    for (int k = 0; k < vals.Length; k++)
                    {
                        if (newSort[k] == null)
                            newSort[k] = vals[i];
                    }
                }
                vals[i] = null;
            }
            vals = newSort;
        }

    }
}
