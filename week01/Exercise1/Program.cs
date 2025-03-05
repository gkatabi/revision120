using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is you first  name?");
        string firstName = Console.ReadLine();
        
        Console.WriteLine("What is your last name?");
        string lastName = Console.ReadLine();
        string names =  string.Concat(lastName, " ",firstName);
        Console.Write("Your name is "+firstName + "," + "" +  names);
        Cosole.WriteLine("What is your first name? ");
        string firstNamez = Console.ReadLine();
        Console.WriteLine("What is your last name? ");
        string lastNamez = Console.ReadLine();
        string Namez = string.Concact (firstNamez , " ", lastNamez );
        Console.Write("Your name is " +lastNamez  + " , " +Namez  );
    }
}