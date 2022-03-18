using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex32
{
    public class Student : Person, IObserver
    {
        private ISubject academy;

        public string Message { get; set; }
        public Student(ISubject academy, string name) : base(name)
        {
            this.academy = academy;
        }

        public void Update()
        {
            if (academy is Academy ac)
            {
                Console.WriteLine($"Studerende {Name} modtog nyheden '{ac.Message}' fra akademiet {ac.Address}");
            }
        }

    }
}
