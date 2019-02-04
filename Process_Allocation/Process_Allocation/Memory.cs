using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Process_Allocation
{
    class Memory
    {
        List<Memory> memory = new List<Memory>();
        List<Memory> process = new List<Memory>();
        private string name;
        private short size;
        private int unusedSpace;

        public string gName
        {
            get { return name; }
        }

        public short gSize
        {
            get { return size; }
        }

        public int uSpace
        {
            get { return unusedSpace; }
            set { unusedSpace = value; }
        }

        public Memory()
        {
        }

        public Memory(string Name, short Size)
        {
            this.name = Name;
            this.size = Size;
        }

        public void ListAdder(short processNumber)
        {
            //For loop that takes in the memory block name and size, as well as the Process Name and size
            for (int i = 0; i < processNumber; i++)
            {
                //Inputs for memory that then adds the memory object to the memory list
                Console.WriteLine("Please enter in the name of the Memory block");
                string name = Console.ReadLine();
                Console.WriteLine("Please enter in the Memory block size");
                short size = Convert.ToInt16(Console.ReadLine());
                memory.Add(new Memory(name, size) { uSpace = size });

                //Take the inputs to add objects to the process list
                Console.WriteLine("Please enter in the name of the Process block");
                string processName = Console.ReadLine();
                Console.WriteLine("Please enter in the size of the process");
                short processSize = Convert.ToInt16(Console.ReadLine());
                process.Add(new Memory(processName, processSize));
            }
        }

        public void Allocation(short processNumber, string criteria)
        {
            SizeComparer sc = new SizeComparer();
            SizeComparer bc = new SizeComparer();
            sc.SortBy = SizeComparer.SortCriteria.SmallFirst;
            bc.SortBy = SizeComparer.SortCriteria.BigFirst;

            int extraSpace = 0;

            if (criteria == "best-fit")
            {
                memory.Sort(sc);
                process.Sort(sc);
            }

            else if (criteria == "worst-fit")
            {
                memory.Sort(bc);
                process.Sort(sc);
            }

            for (int i = 0; i < processNumber; i++)
            {
               int currentMemory = 0;
               Boolean fit = false;
               while (fit == false)
               {
                   if (process[i].gSize <= memory[currentMemory].uSpace)
                   {
                       memory[currentMemory].uSpace = memory[currentMemory].uSpace - process[i].gSize;
                       fit = true;
                       //Display the output
                       Console.WriteLine("Process " + process[i].gName + " is in Memory block " + memory[currentMemory].gName);
                   }
                   else
                       currentMemory++;
               }

            }

            for (int i = 0; i < processNumber; i++)
            {
                extraSpace = extraSpace + memory[i].uSpace;
                memory[i].uSpace = memory[i].gSize;
            }


            Console.WriteLine("Total unused space is " + extraSpace + ".\n");
        }


    }
}
