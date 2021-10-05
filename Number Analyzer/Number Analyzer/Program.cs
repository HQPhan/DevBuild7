using System;

namespace Number_Analyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Ask the user for their name and address the user throughout app
            //2. Prompts user to input an integer between 1 an 100
            //3. Print to console based on conditions
                //a. If 1 < int <= 59 and odd, print the number and "Odd"
                //b. If int is between 2-25 and is even, print "Even and less than 25"
                //c. If int is between 26-60 and is even, print "Even"
                //d. If int > 60 and is even, print the number and "Even"
                //e. If int > 60 and odd, print the number and "Odd"
            //4. Ask user if they want to go again.

            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();

            Console.WriteLine($"Hello {name}! Welcome to the Number Analyzer!");

            bool isCorrect = true;

            while (isCorrect == true)
            {
                Console.WriteLine("Please input a positive integer between 1 and 100: ");
                int x = int.Parse(Console.ReadLine());

                if (x > 0 && x < 101)
                {
                    if (x % 2 == 0 && x > 60)
                    {
                        Console.WriteLine($"{name}, your number {x} is even.");
                    }
                    else if (x % 2 == 0 && x > 0 && x < 25)
                    {
                        Console.WriteLine($"{name}, your number is even and less than 25.");
                    }
                    else if (x % 2 == 0 && x >= 26 && x <= 60)
                    {
                        Console.WriteLine($"{name}, your number is even.");
                    }
                    else
                        Console.WriteLine($"{name}, your number {x} is odd.");
                }
                else
                {
                    Console.WriteLine($"{name}, your number {x} is NOT a positive integer between 1 and 100.");
                }

                Console.WriteLine("Would you like to play again? (y/n)");
                string response = Console.ReadLine().ToLower();

                if (response == "y")
                {
                    isCorrect = true;
                }
                else
                {
                    Console.WriteLine($"{name}, thank you for using the Number Analyzer!");
                    Console.WriteLine("Good bye!");
                    break;
                }

            }

        }

    }
}
