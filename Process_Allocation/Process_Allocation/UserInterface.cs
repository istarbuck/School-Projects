using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Process_Allocation
{
    class UserInterface
    {


        static void Main(string[] args)
        {

            Console.WriteLine("Please enter in the number of process and memory blocks");
            short processNumber = Convert.ToInt16(Console.ReadLine());
            Memory user = new Memory();

            user.ListAdder(processNumber);
            user.Allocation(processNumber, "first-fit");
            user.Allocation(processNumber, "best-fit");
            user.Allocation(processNumber, "worst-fit");
            Console.ReadLine();

        }

    }
}
