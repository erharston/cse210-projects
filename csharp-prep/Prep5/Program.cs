using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        static void Main()
        {
            DisplayWelcome();

            string name = PromptUserName();

            int number = PromptUserNumber();

            int squaredNum = SquaredNumber(number);

            DisplayResult(name, squaredNum);

        }
        
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }

        static int SquaredNumber(int number)
        {
            int squaredNum = number*number;

            return squaredNum;
        }

        static void DisplayResult(string name, int squaredNum)
        {
            Console.WriteLine($"{name}, the square of your number is {squaredNum}");
        }

        Main();
    }
}