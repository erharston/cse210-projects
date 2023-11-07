using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        int number = -1;

        List<int> numbers = new List<int>();

        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            numbers.Add(number);


        } while (number != 0); 

        int sum = 0;

        for (int i = 0; i < numbers.Count; i++)
        {
            sum = numbers[i] + sum;
        } 

        Console.WriteLine($"The sum is: {sum}");
        
        int length = numbers.Count - 1;
        float average = ((float)sum)/length;

        Console.WriteLine($"The average is: {average}");

        int max = -10000000;
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        } 

        Console.WriteLine($"The largest number is: {max}");
    }

}