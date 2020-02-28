using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    public class Swapper
    {
        public static void Swap(long[] massive, int i, int j, ref long swaps)
        {
            swaps++;
            long temp = massive[i];
            massive[i] = massive[j];
            massive[j] = temp;
        }
    }
}
