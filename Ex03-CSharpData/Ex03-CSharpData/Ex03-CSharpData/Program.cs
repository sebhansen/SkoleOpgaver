using System;

namespace Ex03_CSharpData
{
    class Program
    {
        static void Main(string[] args)
        {
            int function;
            start:
            Console.WriteLine("Ex03-CSharpData - Beregner");
            Console.WriteLine("Vælg hvilken funktion du vil tage i brug");
            Console.WriteLine("1. Beregn areal af rektangel\n" +
                              "2. Beregn hældning af linjestykke\n" +
                              "3. String length\n" +
                              "4. String Substring\n" +
                              "5. IndexOf()");
                               
            function = Convert.ToInt32(Console.ReadLine());
            if (function == 1) // Beregn rektangel
            {
                try
                {
                    Console.WriteLine("Skriv rektanglets højde: ");
                    int SquareHeight = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Skriv rektanglets længde: ");
                    int SquareLength = Convert.ToInt32(Console.ReadLine());
                    int SquareArea = SquareHeight * SquareLength;
                    Console.WriteLine($"Arealet af rektanglet er {SquareArea}");
                    Console.WriteLine("\nTryk på en vilkårlig tast for at gå tilbage til menuen");
                    Console.ReadLine();
                    Console.Clear();
                    goto start;
                }
                catch (Exception)
                {
                    Console.WriteLine("Noget gik galt.\nTryk på en vilkårlig tast for at gå tilbage til menuen");
                    Console.ReadLine();
                    Console.Clear();
                    goto start;
                    throw;
                }
            }
            else if (function == 2) // Beregn hældning af linjestykke
            {
                try
                {
                    Console.WriteLine("Skriv x1's koordinat: ");
                    double x1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Skriv y1's koordinat: ");
                    double y1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Skriv x2's koordinat: ");
                    double x2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Skriv y2's koordinat: ");
                    double y2 = Convert.ToInt32(Console.ReadLine());
                    double slope = (y2 - y1) / (x2 - x1);
                    Console.WriteLine($"Hældningen på linjestykket er {slope}");
                    Console.WriteLine("\nTryk på en vilkårlig tast for at gå tilbage til menuen");
                    Console.ReadLine();
                    Console.Clear();
                    goto start;
                }
                catch (Exception)
                {
                    Console.WriteLine("Noget gik galt.\nTryk på en vilkårlig tast for at gå tilbage til menuen");
                    Console.ReadLine();
                    Console.Clear();
                    goto start;
                    throw;
                }
            }
            else if (function == 3) // Find antal af karakterer i et ord/en sætning
            {
                try 
                {
                    Console.WriteLine("Skriv en sætning eller et ord, Så fortæller vi dig hvor mange karakterer der er.");
                    string UserInput = Console.ReadLine();
                    Console.WriteLine($"Dit input indeholder {UserInput.Length} karakterer");
                    Console.WriteLine("\nTryk på en vilkårlig tast for at gå tilbage til menuen");
                    Console.ReadLine();
                    Console.Clear();
                    goto start;
                }
                catch (Exception)
                {
                    Console.WriteLine("Noget gik galt.\nTryk på en vilkårlig tast for at gå tilbage til menuen");
                    Console.ReadLine();
                    Console.Clear();
                    goto start;
                    throw;
                }
            }
            else if (function == 4) // Substring
            {
                try
                {
                    Console.WriteLine("Skriv en sætning eller et ord.");
                    string UserStringInput = Console.ReadLine();
                    Console.WriteLine($"Dit input indeholder {UserStringInput.Length} karakterer");
                    Console.WriteLine("Vælg hvorfra dit nye input skal starte, så fjernes alt der står før den valgte karakter");
                    int UserIntInput = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{UserStringInput.Substring(UserIntInput)}");
                    Console.WriteLine("\nTryk på en vilkårlig tast for at gå tilbage til menuen");
                    Console.ReadLine();
                    Console.Clear();
                    goto start;
                }
                catch (Exception)
                {
                    Console.WriteLine("Noget gik galt.\nTryk på en vilkårlig tast for at gå tilbage til menuen");
                    Console.ReadLine();
                    Console.Clear();
                    goto start;
                    throw;
                }
            }
            else if (function == 5) // IndexOf
            {
                try
                {
                    Console.WriteLine("Skriv et ord eller en sætning");
                    string UserInput = Console.ReadLine();
                    Console.WriteLine($"Dit input indeholder {UserInput.Length} karakterer");
                    Console.WriteLine("Skriv hvilken karakter du vil kende positionen på");
                    char UserChar = Convert.ToChar(Console.ReadLine());
                    int CharPosition = UserInput.IndexOf(UserChar);
                    Console.WriteLine($"Positionen for dit input er nummer {CharPosition}");
                    Console.WriteLine("\nTryk på en vilkårlig tast for at gå tilbage til menuen");
                    Console.ReadLine();
                    Console.Clear();
                    goto start;
                }
                catch (Exception)
                {
                    Console.WriteLine("Noget gik galt.\nTryk på en vilkårlig tast for at gå tilbage til menuen");
                    Console.ReadLine();
                    Console.Clear();
                    goto start;
                    throw;
                    throw;
                }
            }
            else // Ved fejlinput, smid brugeren til toppen.
            {
                Console.WriteLine("Noget gik galt. Tryk på en vilkårlig tast for at gå tilbage til menuen.");
                Console.ReadLine();
                Console.Clear();
                goto start;
            }
        }
    }
}
