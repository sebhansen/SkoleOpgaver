using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling
{
    public class PriorityQueue
    {
        List<PCB> pcbs = new();
        public void Enqueue(PCB pcb)
        {
            for (int i = 0; i < pcbs.Count(); i++)
            {
                pcbs.Add(new PCB(pcb.ProcessName, pcb.ProcessPriority));
            }

        }
        public void Dequeue()
        {

        }

        public void Reprioritize(string processName, int newPriority)
        {

        }

        public override string ToString()
        {
            return "{"+$"{pcbs}"+"}";
        }
    }
}
