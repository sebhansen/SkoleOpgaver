using System;

namespace Ex01_FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int Age;
            string Name;

            Console.Write("Skriv dit navn: ");
            Name = Console.ReadLine();
            Console.Write("Skriv din alder: ");
            Age = Convert.ToInt32(Console.ReadLine()) - 10;

            Console.WriteLine(Name + " er " + Age + " år gammel");
            //Console.WriteLine($"{Name} er {Age} år gammel");
            //Console.WriteLine("{0} er {1} år gammel", Name, Age);

            Console.WriteLine("Tryk på en knap for at fortsætte");
            Console.ReadKey();
        }
    }
}
