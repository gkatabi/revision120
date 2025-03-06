using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the magic number game.");
        Console.WriteLine("I have a number between 1 to 100");
        Console.WriteLine("Guess the number");
        string number = Console.ReadLine();
        float Number = float .Parse(Console.ReadLine());
        
        string guess = "68"
        if (Number != Number < "68")
        {
           Console.WriteLine("Guess higher than "+ number);
        }
        else if (Number != "68" && Number > "68")
        {
            Console.WriteLine("guess lower than"+ number);
        }
        else 
        {
            Console.WriteLine("you got it");
        }
    }
}