using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    public class Swapper
    {
        public static void Swap<T>(T[] massive, int i, int j, ref int swaps)
        {
            swaps++;
            T temp = massive[i];
            massive[i] = massive[j];
            massive[j] = temp;
        }
    }
}
