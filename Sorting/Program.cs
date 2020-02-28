﻿using System;
using System.Linq;
using System.Collections.Generic; 

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ISort> sorts = new List<ISort>()
            {
                new BubleSort(), new InsertionSort(), new TreeSort(), new QuickSort()
            };
            Random random = new Random();             
            for (int i = 10; i <= 40; i = i * 2)
            {
                Console.WriteLine($"Количество элементов: {i}");
                int[] array = new int[i]; 
                for (int j = 0; j < array.Length; j++)
                    array[j] = random.Next(-99, 99);
                Console.WriteLine($"Оригинальный массив: \n{string.Join(' ', array)}");
                int[] sortedArray = (int[])array.Clone();
                Array.Sort(sortedArray);
                Console.WriteLine($"Оригинальный отсортированный массив: \n{string.Join(' ', sortedArray)}");
                int[] reverseSortedArray = (int[])sortedArray.Clone();
                reverseSortedArray = reverseSortedArray.Reverse().ToArray();
                Console.WriteLine($"Оригинальный отсортированный в обратном порядке массив: \n{string.Join(' ', reverseSortedArray)}");
                List<int[]> arraysForSort = new List<int[]>() { array, sortedArray, reverseSortedArray };
                Console.WriteLine(); 
                foreach (var sort in sorts)
                {
                    Console.WriteLine(sort.GetSortName());
                    foreach (var arrayForSort in arraysForSort)
                    {
                        var arrayForTest = (int[])arrayForSort.Clone();
                        Console.WriteLine($"Массив на входе: \n{string.Join(' ', arrayForTest)}");
                        var (compares, swaps) = sort.Sort(arrayForTest);
                        Console.WriteLine($"Результат: \n{string.Join(' ', arrayForTest)}");
                        Console.WriteLine($"Сравнения и перестановки: {compares}, {swaps}"); 
                    }
                    Console.WriteLine(); 
                }
                Console.Write("\n\n"); 
            }

            //long[] masForBubble = new long[] { 8, 9, 10, 7, 6, 5, 4, 0, -100, 200, 45, 1, 1, 6, 66 };
            //long[] masForInsertion = (long[])masForBubble.Clone();
            //long[] masForQuick = (long[])masForBubble.Clone();
            //long[] masForCheck = (long[])masForBubble.Clone();
            //Array.Sort(masForCheck);
            //BubleSort bubleSort = new BubleSort();
            //bubleSort.Sort(masForBubble);
            //InsertionSort insertionSort = new InsertionSort();
            //insertionSort.Sort(masForInsertion);
            //QuickSort quickSort = new QuickSort();
            //quickSort.Sort(masForQuick);             
        }
    }
}
