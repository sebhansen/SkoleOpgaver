using System;

namespace Ex04___While_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            bool menuLoop = true;
            while (menuLoop) //Så længe vores menu loop er true, kører vores program
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("Valgmuligheder med ** er ikke færdige\n");
                Console.WriteLine("1. hej i for loop");
                Console.WriteLine("2. hej i while loop");
                Console.WriteLine("3. hej i do while loop");
                Console.WriteLine("4. Heltalsdivision");
                Console.WriteLine("5. Output hver anden karakter");
                Console.WriteLine("6. Output kun digits fra string");
                Console.WriteLine("7. Output digits samt operator (+ og -) fra string");
                Console.WriteLine("8. **Skan og udregn regnestykke med + og -");
                Console.WriteLine("9. **Skan og udregn regnestykke med multiplikation og division");
                Console.WriteLine("0. Afslut program");
                int userChoice = Convert.ToInt32(Console.ReadLine());
                string hej = "hej";
                int count = hej.Length;
                int i = 0;
                switch (userChoice)
                {
                    case 1: //hej i for loop
                        for (i = 0; i < count; i++) //Kører indtil count ikke længere er større end i
                        {
                            Console.WriteLine($"With for-loop {i}-{hej[i]}"); //outputter vores index samt karakter.
                        }
                        break;
                    case 2:
                        i = 0;
                        while (count > 0) //Kører indtil vores count ikke længere er større end 0
                        {
                            Console.WriteLine($"With while-loop {i} {hej[i++]}");
                            count--;
                        }
                        break;

                    case 3:
                        count = 0;
                        i = 0;
                        do
                        {
                            Console.WriteLine($"With do while-loop {i}-{hej[i++]}");
                            count++;
                        } while (count < hej.Length); //Kører indtil count ikke længere er mindre end hej.length
                        break;

                    case 4:
                        //Heltalsdivision - Ikke færdig / korrekt
                        Console.WriteLine("Indsæt værdi a");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Indsæt værdi b");
                        int b = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine($"Heltal = {a / b}");
                        double c = (a / b);
                        Console.WriteLine($"Rest = {(a / b) % b}");
                        break;

                    case 5:
                        string input = "JensJensen";
                        for (i = 0; i < input.Length; i+=2)
                        {
                            Console.WriteLine(input[i]);
                        }
                        break;

                    case 6:
                        input = "J1hn J0hns0n";
                        count = 0;
                        while (count < input.Length)
                        {
                            if (char.IsDigit(input[count])) //Vi tjekker for hver karakter i vores string om hvorvidt der er tal eller ej
                                                            //char.IsDigit er en bool der viser os om det så er true eller false
                            {
                                Console.WriteLine(input[count]); //Vi udskriver KUN hvis char.IsDigit er kommet tilbage som true. Dermed kommer der kun tal ud
                            }
                            count++; //Vi får count til at stige med en for at rykke videre til næste karakter i vores string.
                        }
                        break;

                    case 7:
                        input = "J1+hn J-0-hns0n";
                        count = 0;
                        while (count < input.Length)
                        {
                            if (char.IsDigit(input[count]) || char.IsPunctuation(input[count]) || char.IsSymbol(input[count])) //Vi tjekker om vores string enten indeholder tal eller symboler
                                                                                                                               //Dette er sikkert en super kompliceret måde at gøre det på
                            {
                                Console.WriteLine(input[count]);
                            }
                            count++;
                        }
                        break;

                    case 8:

                        break;

                    case 9:

                        break;

                    case 0:
                        menuLoop = false;
                        break;

                    default:
                        Console.WriteLine("Prøv et nummer der står på menuen");
                        break;
                }
            }
        }
    }
}
