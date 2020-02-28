using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    public class QuickSort : ISort
    {
        public (int, int) Sort<T>(T[] array) where T : IComparable<T>
        {
            return SortWithBorders(array, 0, array.Length - 1); 
        }

        private (int, int) SortWithBorders<T>(T[] array, int left, int right) where T : IComparable<T>
        {
            if (left >= right)
                return (0, 0);
            int compares = 0, swaps = 0; 

            var (pivot, pComp, pSwap) = Partition(array, left, right);
            compares += pComp;
            swaps += pSwap;

            var (q1Comp, q1Swap) = SortWithBorders(array, left, pivot - 1);
            compares += q1Comp;
            swaps += q1Swap;

            var (q2Comp, q2Swap) = SortWithBorders(array, pivot + 1, right);
            compares += q2Comp;
            swaps += q2Swap; 

            return (compares, swaps); 
        }

        private (int, int, int) Partition<T>(T[] array, int left, int right) where T : IComparable<T>
        {
            int compares = 0, swaps = 0; 
            int i = left;
            for (int j = left; j <= right; j++)
            {
                compares++; 
                if (array[j].CompareTo(array[right]) <= 0)  
                {
                    Swapper.Swap(array, i, j, ref swaps);
                    i++;                         
                }
            }
            return (i - 1, compares, swaps);
        }

        public string GetSortName()
        {
            return "БЫСТРАЯ СОРТИРОВКА"; 
        }
    }
}
