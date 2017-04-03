using System;

namespace Algos
{
    internal class MergeSort
    {

        private int[] array;
        private int[] tempMergArr;
        private int length;


        public void Sort(int[] inputArr)
        {
            this.array = inputArr;
            this.length = inputArr.Length;
            this.tempMergArr = new int[length];
            doMergeSort(0, length - 1);
        }

        private void doMergeSort(int lowerIndex, int higherIndex)
        {

            if (lowerIndex < higherIndex)
            {
                int middle = lowerIndex + (higherIndex - lowerIndex) / 2;
                // Below step sorts the left side of the array
                doMergeSort(lowerIndex, middle);
                // Below step sorts the right side of the array
                doMergeSort(middle + 1, higherIndex);
                // Now merge both sides
                mergeParts(lowerIndex, middle, higherIndex);
            }
        }

        private void mergeParts(int lowerIndex, int middle, int higherIndex)
        {

            for (int index = lowerIndex; index <= higherIndex; index++)
            {
                tempMergArr[index] = array[index];
            }

            int i = lowerIndex;
            int j = middle + 1;
            int k = lowerIndex;
            while (i <= middle && j <= higherIndex)
            {
                if (tempMergArr[i] <= tempMergArr[j])
                {
                    array[k] = tempMergArr[i];
                    i++;
                }
                else {
                    array[k] = tempMergArr[j];
                    j++;
                }
                k++;
            }
            while (i <= middle)
            {
                array[k] = tempMergArr[i];
                k++;
                i++;
            }
        }

    }
}