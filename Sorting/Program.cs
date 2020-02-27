using System;
using System.Linq; 

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] masForBubble = new long[] { 8, 9, 10, 7, 6, 5, 4, 0, -100, 200, 45, 1, 1, 6, 66 };
            long[] masForInsertion = (long[])masForBubble.Clone();
            long[] masForQuick = (long[])masForBubble.Clone();
            long[] masForCheck = (long[])masForBubble.Clone(); 
            BubleSort bubleSort = new BubleSort();
            bubleSort.Sort(masForBubble);

            Array.Sort(masForCheck); 
        }
    }
}
