using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity9_2
{
    class DateSorter : IComparer<Request>
    {
        public int Compare(Request r1, Request r2)
        {
            return r1.Date.CompareTo(r2.Date);
        }
               
    }
}
