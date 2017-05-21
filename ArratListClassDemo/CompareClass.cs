using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArratListClassDemo
{
    class CompareClass: IComparable
    {
        int value;
        public int CompareTo(object obj)
        {
            if (obj is CompareClass)
            {
                CompareClass temp = (CompareClass)obj;
                return value.CompareTo(temp.value);
            }
            return -99;
        }
    }
}
