using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Process_Allocation
{
    class BigSizeComparer : IComparer<Memory>
    {
         public int Compare(Memory x, Memory y)
        {
           if (x.gSize > y.gSize)
              return -1;
           if (x.gSize < y.gSize)
              return 1;
           else
              return 0;
          }
    }
}
