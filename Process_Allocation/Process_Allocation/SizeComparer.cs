using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Process_Allocation
{
    class SizeComparer : IComparer<Memory>
    {
        public enum SortCriteria
        {
            SmallFirst,
            BigFirst,
        }

        public SortCriteria SortBy = SortCriteria.SmallFirst;

        public int Compare(Memory x, Memory y)
        {
            if (SortBy == SortCriteria.SmallFirst)
            {
                if (x.gSize < y.gSize)
                    return -1;
                if (x.gSize > y.gSize)
                    return 1;
                else
                    return 0;
            }

            else
            {
                if (x.gSize < y.gSize)
                    return 1;
                if (x.gSize > y.gSize)
                    return -1;
                else
                    return 0;
            }


           }
    }
}
