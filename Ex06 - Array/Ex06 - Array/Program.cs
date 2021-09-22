using System;

namespace Ex06___Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ex06 - Array\n");
            const int AGE_AMOUNT = 4;
            double AverageAge = 0;
            //Average age without using array
            //int Age1, Age2, Age3, Age4;
            //Age1 = 22; //Sebastian
            //Age2 = 23; //Sandra
            //Age3 = 29; //Mads
            //Age4 = 21; //Mohammed
            //Console.WriteLine($"Sebastian's age: {Age1}");
            //Console.WriteLine($"Sandra's age: {Age2}");
            //Console.WriteLine($"Mads' age: {Age3}");
            //Console.WriteLine($"Mohammed's age: {Age4}");
            //int AverageAge = (Age1 + Age2 + Age3 + Age4) / AGE_AMOUNT;
            //Console.WriteLine($"Average age is {AverageAge}");

            //Average age using array
            int[] ages = new int[AGE_AMOUNT] { 22, 23, 29, 21 };
            for (int i = 0; i < AGE_AMOUNT; i++)
            {
                Console.WriteLine(ages[i]);
                AverageAge += ages[i];
            }
            Console.WriteLine("\n" + AverageAge / AGE_AMOUNT);
            bool found = false;
            while (!found)
            {
                Console.WriteLine("Type an age to see if it exists in the array");
                int UserInput = 0;
                try
                {
                    UserInput = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Input must be an integer");
                }
                switch (UserInput)
                {
                    case 22:
                        Console.WriteLine($"The age {UserInput} has been found");
                        found = true;
                        break;
                    case 23:
                        Console.WriteLine($"The age {UserInput} has been found");
                        found = true;
                        break;
                    case 29:
                        Console.WriteLine($"The age {UserInput} has been found");
                        found = true;
                        break;
                    case 21:
                        Console.WriteLine($"The age {UserInput} has been found");
                        found = true;
                        break;
                    default:
                        Console.WriteLine($"The age {UserInput} has not been found");
                        break;
                }
            }
            int UserAmount = 0;
            int UserPerson = 0;
            int UserAge = 0;
            Console.WriteLine("How many people should be in the array");
            //int.TryParse(Console.ReadLine(), out UserAmount);
            try
            {
                UserAmount = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Amount must be an integer");
            }
            int[] Ages = new int[UserAmount];
            //Array.Resize(ref Ages, UserAmount); //We change the size of the array by setting it equal to UserAmount, using Resize method
            for (int i = 0; i < UserAmount; i++)
            {
                Console.WriteLine("How old should the person be?");
                //int.TryParse(Console.ReadLine(), out UserAge);
                try
                {
                    UserAge = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Amount must be an integer");
                }
                Ages[i] = UserAge;
            }
            //If you want to be able to choose where in the array you want to change the age.
            /* 
            bool LoopContinue = true;
            while (LoopContinue)
            {
                Console.WriteLine($"Pick a person to set their age. Choose between person 0 to {UserAmount - 1}");
                UserPerson = int.Parse(Console.ReadLine());
                Console.WriteLine("How old should that person be?");
                UserAge = int.Parse(Console.ReadLine());
                Ages[UserPerson] = UserAge;
                Console.WriteLine("Would you like to set another age?\ny or n");
                string UserChoice = Console.ReadLine();
                switch (UserChoice)
                {
                    case "y":
                        break;
                    case "n":
                        LoopContinue = false;
                        break;
                }
            }
            */
            Console.WriteLine("The new array contains the following ages:");
            for (int i = 0; i < UserAmount; i++)
            {
                Console.WriteLine(Ages[i]);
            }
        }
    }
}
