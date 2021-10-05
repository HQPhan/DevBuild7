using System;

namespace RoomCalculatorClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Prompt user for length, width
            // 2. Get user input 2 times and store it
            // 3. Try to parse it into doubles
            // 4. Calculate area
            // 5. Calculate perimeter
            // 6. Calculate carpet tiles
            // 7. Calculate paint cans
            // 8. Figure if the user wishes to continue Y/N
            bool goOn = true;

            while (goOn == true)
            {
                Console.WriteLine("Welcome to the GC Room Calculator");
                Console.WriteLine("Please input a length");
                string inputLen = Console.ReadLine();

                Console.WriteLine("Please input Width");
                string inputWid = Console.ReadLine();

                Console.WriteLine("Please input Height");
                string inputHeight = Console.ReadLine();

                double length = double.Parse(inputLen);
                double width = double.Parse(inputWid);
                double height = double.Parse(inputHeight);

                double area = length * width;
                double volume = length * width * height;
                double perimeter = 2 * length + 2 * width;

                double carpetTiles = area / 5;
                double paintPerimeter = perimeter / 5;

                double paintWalls = (area + 2 * length * height + 2 * width * height) / 25;

                Console.WriteLine($"Length: {length}");
                Console.WriteLine($"Width: {width}");
                Console.WriteLine($"Height: {height}");
                Console.WriteLine();
                Console.WriteLine($"Area: {area}");
                Console.WriteLine($"Volume: {volume}");
                Console.WriteLine($"Perimeter: {perimeter}");
                Console.WriteLine();
                Console.WriteLine($"Carpet Tiles: {carpetTiles}");
                Console.WriteLine($"Perimeter Paint Cans: {paintPerimeter}");
                Console.WriteLine($"Paint Cans for Walls: {paintWalls}");


                bool askAgain = true;

                while (askAgain == true)
                {
                    Console.WriteLine("Would you like to continue? Y/N");
                    string answer = Console.ReadLine().ToLower();
                    //There are possibilities to check for:
                    // Y
                    // N
                    // Anything else

                    if (answer == "y")
                    {
                        askAgain = false;
                        goOn = true;
                    }
                    else if (answer == "n")
                    {
                        askAgain = false;
                        goOn = false;
                        Console.WriteLine("Good Bye");
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry I didn't understand that");
                        Console.WriteLine("Let's try that again");
                    }

                }

            }

        }
    }
}
