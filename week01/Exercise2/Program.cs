using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string ValueFromUser= Console.ReadLine();
        /*x = the percentage*/
        int x = int.Parse(ValueFromUser);
        
        string letter ="";

        if (x>=90)
        {
            letter = "A";
        }
        else if (x>=80)
        {
            letter = "B";
        }
        else if (x>=70)
        {
            letter = "C";
        }
        else if (x>=60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }
        Console.WriteLine($"Ypur grade is: {letter}");

        if (x>=70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    } 
}