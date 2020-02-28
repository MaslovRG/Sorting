using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    public class BubleSort : ISort
    {
        public (int, int) Sort<T>(T[] array) where T : IComparable<T>
        {
            int compares = 0, swaps = 0; 
            bool f = false; 
            for (int j = 0; j < array.Length - 1 && !f; j++)
            {
                f = false; 
                for (int i = 0; i < array.Length - j - 1; i++)
                {
                    compares++; 
                    if (array[i].CompareTo(array[i + 1]) > 0)
                    {
                        Swapper.Swap(array, i, i + 1, ref swaps); 
                    }
                }
            }
            return (compares, swaps); 
        }
        
        public string GetSortName()
        {
            return "СОРТИРОВКА ПУЗЫРЬКОМ"; 
        }
    }
}
