using System;

namespace Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {

            PCB pcb = new();
            pcb.ProcessName = "A";
            pcb.ProcessPriority = 1;
            Console.WriteLine(pcb.ToString());
        }
    }
}
