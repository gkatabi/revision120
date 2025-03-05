using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string grades = Console.ReadLine();
        int percentage  = int.Parse(grades);

        string letter  = ""

        if (percentage >= "90")
        {
           letter= "A";
        }
        else if (percentage >= "80"  && percentage < "90")
        {
            letter"B";
        }
        else if (percentage >= "70" && percentage < "80")
        {
            letter = "C";
        } 
        else if (percentage >= "60" && percentage < "70")
        {
            letter ="D";
        }
        if (percentage >= 50 && grades < "60")
        { 
            letter ="P";  
        }
        else (percentage  < "50")
        {
            letter ="F";
        }
        Console>WriteLine($"your grade is:   {letter} ");

        if (percentage >= "70")
#       {
#          Console.WriteLine ("You passed");

        }
        if (percentage < "70")
        {
           Console.WriteLine("Better luck next time");
        }
    }
}