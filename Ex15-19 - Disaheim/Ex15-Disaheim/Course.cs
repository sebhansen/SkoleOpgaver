using System;
using System.Collections.Generic;
using System.Text;

namespace Ex15_Disaheim
{
    public class Course
    {
        public string Name { get; set; }
        public int DurationInMinutes { get; set; }
        public Course() { }
        public Course(string name)
        {
            Name = name;
        }
        public Course(string name, int durationInMinutes)
        {
            Name = name;
            DurationInMinutes = durationInMinutes;
        }
         
        public override string ToString()
        {
            return ($"Name: {Name}, Duration in Minutes: {DurationInMinutes }");
        }
    }
}
