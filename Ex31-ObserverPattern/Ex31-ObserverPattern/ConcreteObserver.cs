using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex31_ObserverPattern
{
    public class ConcreteObserver : Observer
    {
        private ConcreteSubject subject;

        public int State = 0;

        public ConcreteObserver(ConcreteSubject subject)
        {
            this.subject = subject;
        }

        public override void Update()
        {
            State = subject.State;
            Console.WriteLine($"New state is: {State}");
        }
    }
}
