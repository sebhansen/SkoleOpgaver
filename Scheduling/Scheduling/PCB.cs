using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling
{
    public class PCB
    {
        public PCB() { 
        }
        public PCB(string processName, int processPriority)
        {
            processName = ProcessName;
            processPriority = ProcessPriority;
        }

        private string _processName;

        public string ProcessName
        {
            get { return _processName; }
            set { _processName = value; }
        }

        private int _processPriority;

        public int ProcessPriority
        {
            get { return _processPriority; }
            set
            {
                if (_processPriority <= 0)
                {
                    _processPriority = 1;
                }
                else
                {
                    _processPriority = value;
                }
            }
        }


        public override string ToString()
        {
            return $"{ProcessName}({ProcessPriority})";
        }
    }
}
