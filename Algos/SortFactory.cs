using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
    public class SortFactory : ISort
    {
        public void Sort(int[] numbers, EnumFactory.SortTypes e)
        {
            switch (e)
            {
                case EnumFactory.SortTypes.QUICK:
                    QuickSort sa = new QuickSort();
                    sa.Sort(numbers);
                    break;
                case EnumFactory.SortTypes.MERGE:
                    MergeSort ms = new MergeSort();
                    ms.Sort(numbers);
                    break;
                case EnumFactory.SortTypes.SELECTION:
                    SelectionSort ss = new SelectionSort();
                    ss.Sort(numbers);
                    break;
                case EnumFactory.SortTypes.BINARY:
                    //var bs = new BinarySort();
                    //bs.Sort(numbers);
                    break;
                default:
                    break;
            }
        }

    }      
}
