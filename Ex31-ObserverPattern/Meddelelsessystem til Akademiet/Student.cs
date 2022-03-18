using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akademiet
{
    public class Student : Observer
    {
        private Academy subject;
        public string Message { get; set; }
        public string Name { get; set; }

        public Student(Academy subject, string name)
        {
            this.subject = subject;
            Name = name;
        }

        public override void Update()
        {
            Console.WriteLine($"Studerende {Name} modtog nyheden '{subject.Message}' fra akademiet {subject.Name}");
        }

    }
}
