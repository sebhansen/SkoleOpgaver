using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex32
{
    public class Academy : Organization, ISubject
    {
        private string message;
        public string Message
        {
            get { return message; }
            set { message = value;
                  Notify();
                }
        }


        public Academy(string address, string name) : base(name)
        {
            base.Address = address;
        }

        private List<IObserver> students = new List<IObserver>();

        public void Attach(IObserver o)
        {
            students.Add(o);
        }

        public void Detach(IObserver o)
        {
            students.Remove(o);
        }

        public void Notify()
        {
            foreach (var o in students)
            {
                o.Update();
            }
        }
    }
}
