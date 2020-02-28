using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    public interface ISort
    {
        (long, long) Sort(long[] massive); 
    }
}
