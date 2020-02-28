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
            for (int i = 1; i < array.Length; i++)
            {
                T cur = array[i];
                int j = i;
                compares++; 
                while (j > 0 && cur.CompareTo(array[j - 1]) < 0)
                {
                    array[j] = array[j - 1];
                    j--;
                    compares++;
                    swaps++; 
                }
                array[j] = cur;
                swaps++; 
            }
            return (compares, swaps); 
        }

        public string GetSortName()
        {
            return "СОРТИРОВКА ВСТАВКАМИ";
        }
    }
}
