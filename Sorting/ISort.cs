using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    public interface ISort
    {
        // returns 
        // 1 - compares
        // 2 - swaps 
        (int, int) Sort<T>(T[] array) where T : IComparable<T>;
        string GetSortName(); 
    }
}
