using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    public class BubleSort : ISort
    {
        public void Sort(long[] massive)
        {
            bool f = false; 
            for (int j = 0; j < massive.Length - 1 && !f; j++)
            {
                f = false; 
                for (int i = 0; i < massive.Length - j - 1; i++)
                {
                    if (massive[i] > massive[i + 1])
                    {
                        long temp = massive[i];
                        massive[i] = massive[i + 1];
                        massive[i + 1] = temp; 
                    }
                }
            }
        }
    }
}
