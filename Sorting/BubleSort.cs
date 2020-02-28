using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    public class BubleSort : ISort
    {
        public (long, long) Sort(long[] massive)
        {
            long compares = 0, swaps = 0; 
            bool f = false; 
            for (int j = 0; j < massive.Length - 1 && !f; j++)
            {
                f = false; 
                for (int i = 0; i < massive.Length - j - 1; i++)
                {
                    compares++; 
                    if (massive[i] > massive[i + 1])
                    {
                        Swapper.Swap(massive, i, i + 1, ref swaps); 
                    }
                }
            }
            return (compares, swaps); 
        }
    }
}
