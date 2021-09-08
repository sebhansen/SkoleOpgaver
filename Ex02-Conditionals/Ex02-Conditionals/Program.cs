using System;

namespace Ex02_Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            Console.Clear();
            Console.WriteLine("Ex02-Conditionals");
            string name;
            int age;
            Console.WriteLine("Skriv dit navn: ");
            name = Console.ReadLine();
            Console.WriteLine("Skriv din alder: ");
            age = Convert.ToInt32(Console.ReadLine());

            //check age to decide outcome
            //if (age < 0)
            //{
            //    Console.WriteLine("Din alder skal være over 0");
            //}
            //else if (age <= 12)
            //{
            //    Console.WriteLine($"{name} er {age} og kan dermed vurderes til at være et barn");
            //}
            //else if (age < 20)
            //{
            //    Console.WriteLine($"{name} er {age} og kan dermed vurderes til at være en teenager");
            //}
            //else if (age < 26)
            //{
            //    Console.WriteLine($"{name} er {age} og kan dermed vurderes til at være en studerende");
            //}
            //else if (age < 68)
            //{
            //    Console.WriteLine($"{name} er {age} og kan dermed vurderes til at være i arbejde");
            //}
            //else if (age > 67)
            //{
            //    Console.WriteLine($"{name} er {age} og kan dermed vurderes til at være en pensionist");
            //}
            //if user input is lower than 0 or not an int
            //else
            //{
            //    Console.WriteLine("Noget gik galt. Tryk Enter for at prøve igen");
            //    Console.ReadLine();
            //    goto start;
            //}
            //allow user to go back to the top and try again
            //Console.WriteLine("Tryk på en knap for at starte forfra.");
            //Console.ReadKey();
            //goto start;

            // another way of doing the same thing with less code.
            string message = $"{name} er {age} og kan dermed vurderes til at være";
            if (age < 0)
                Console.WriteLine("Din alder skal være over 0");
            else if (age <= 12)
                Console.WriteLine($"{message} et barn");
            else if (age < 20)
                Console.WriteLine($"{message} en teenager");
            else if (age < 26)
                Console.WriteLine($"{message} en studerende");
            else if (age < 68)
                Console.WriteLine($"{message} i arbejde");
            else if (age > 67)
                Console.WriteLine($"{message} en pensionist");
            // if user input is lower than 0 or not an int
            else
            {
                Console.WriteLine("Noget gik galt. Tryk Enter for at prøve igen");
                Console.ReadLine();
                goto start;
            }
            // allow user to go back to the top and try again
            Console.WriteLine("Tryk på en knap for at starte forfra.");
            Console.ReadKey();
            goto start;
        }
    }
}
