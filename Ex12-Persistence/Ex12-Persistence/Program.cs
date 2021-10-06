﻿using System;

namespace Ex12_Persistence
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Anders Andersen", new DateTime(1975, 8, 23), 175.9, true, 3);
            DataHandler handler = new DataHandler("Data.txt");
            handler.SavePerson(person);
            Console.WriteLine("Writing Person: ");
            Console.WriteLine(person.MakeTitle());
        }
    }
}
