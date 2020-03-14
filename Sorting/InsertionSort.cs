using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    public class InsertionSort : ISort
    {
        public (int, int) Sort<T>(T[] array) where T : IComparable<T>
        {
            int compares = 0, swaps = 0;
            for (int i = 0; i < array.Length; i++)
            {
                var minIndex = i; 
                for (int j = i + 1; j < array.Length; j++)
                {
                    compares++; 
                    if (array[j].CompareTo(array[minIndex]) < 0)
                    {
                        minIndex = j; 
                    }
                }
                if (minIndex != i)
                    Swapper.Swap(array, i, minIndex, ref swaps);
            }
            return (compares, swaps); 
        }

        public string GetSortName()
        {
            return "СОРТИРОВКА ВСТАВКАМИ";
        }
    }
}
