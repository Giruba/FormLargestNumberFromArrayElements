using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FormLargestNumberFromArrayElements
{
    class StringConcatenatorComparer : IComparer<String>
    {
       int IComparer<string>.Compare(string x, string y)
        {
            string xy = x + y;
            string yx = y + x;
            return yx.CompareTo(xy);
        }
    }
}
