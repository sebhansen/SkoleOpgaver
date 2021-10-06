using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Ex12_Persistence
{
    public class DataHandler
    {
        private string dataFileName;
        public string DataFileName
        {
            get { return dataFileName; }
        }
        public DataHandler(string dataFileName)
        {
            this.dataFileName = dataFileName;
        }
        public void SavePerson(Person person)
        {
            StreamWriter sw = new StreamWriter(DataFileName);
            sw.WriteLine(person.MakeTitle());
            sw.Close(); 
        }

        public Person LoadPerson()
        {
            StreamReader sr = new StreamReader(DataFileName);
            string[] personAttributes = sr.ReadLine().Replace("00.00.00", "").Split(";");
            string Name = (personAttributes[0]);
            DateTime BirthDate = DateTime.Parse(personAttributes[1]);
            double Height = double.Parse(personAttributes[2]);
            bool IsMarried = bool.Parse(personAttributes[3]);
            int NoOfChildren = int.Parse(personAttributes[4]);

            Person person = new Person(Name, BirthDate, Height, IsMarried, NoOfChildren);
            sr.Close();

            return person;
        }
        public void SavePersons(Person[] persons)
        {
            StreamWriter sw = new StreamWriter(DataFileName);
            foreach (var person in persons)
            {
                sw.WriteLine(person.MakeTitle());
            }
            sw.Close();
        }
        public Person[] LoadPersons()
        {
            Person[] persons = new Person[dataFileName.Length];
            string lines;
            int count = 0;
            StreamReader sr = new StreamReader(dataFileName);
            while ((lines = sr.ReadLine())!=null)
            {
                string[] personAttributes = lines.Split(";") ;
                persons[count] = new Person(personAttributes[0],
                DateTime.Parse(personAttributes[1]),
                double.Parse(personAttributes[2]),
                bool.Parse(personAttributes[3]),
                int.Parse(personAttributes[4]));
                count++;
            }
            sr.Close();
            return persons;
        }
    }
}
