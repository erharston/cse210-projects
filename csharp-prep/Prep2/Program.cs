using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string gradeInput = Console.ReadLine();
        int gradePercentage = int.Parse(gradeInput);

        if (gradePercentage >= 90)
        {
            Console.WriteLine("Your letter grade is an A.");
        }
        else if (gradePercentage >= 80)
        {
            Console.WriteLine("Your letter grade is a B.");
        }
        else if (gradePercentage >= 70)
        {
            Console.WriteLine("Your letter grade is a C.");
        }
        else if (gradePercentage >= 60)
        {
            Console.WriteLine("Your letter grade is a D.");
        }
        else 
        {
            Console.WriteLine("Your letter grade is an F.");
        }

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("Maybe next time.");
        }
    }
}