using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Process_Allocation
{
    class Process
    {
        private string name;
        private short size;

        public string gName
        {
            get { return name; }
        }

        public int gSize
        {
            get { return size; }
        }

        public Process(string Name, short Size)
        {
            this.name = Name;
            this.size = Size;
        }
    }
}
