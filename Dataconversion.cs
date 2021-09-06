using System;
class Data
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter the age");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the age at which u wish to retire");
        int expectedRetirement = int.Parse(Console.ReadLine());
        Console.WriteLine("u r going to retire after " + (expectedRetirement - age) + "years");
    }
}


    
