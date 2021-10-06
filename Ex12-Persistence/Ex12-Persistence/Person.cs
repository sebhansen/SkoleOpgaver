using System;
using System.Collections.Generic;
using System.Text;

namespace Ex12_Persistence
{
    public class Person
    {
        public string Name;
        public DateTime BirthDate;
        public double Height;
        public bool IsMarried;
        public int NoOfChildren;
        public Person(string name, DateTime birthDate, double height, bool isMarried, int noOfChildren)
        {
            Name = name;
            BirthDate = birthDate;
            Height = height;
            IsMarried = isMarried;
            NoOfChildren = noOfChildren;
        }

        public string MakeTitle()
        {
            return ($"{Name};{BirthDate};{Height};{IsMarried};{NoOfChildren}").ToString();
        }
    }
}