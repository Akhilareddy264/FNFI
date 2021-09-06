using System;
class Program
    {
    static void Main(string[] args)
    {
        Console.WriteLine("enter the name please");
        string name = Console.ReadLine();
        Console.WriteLine("enter the age please");
        string age = Console.ReadLine();
        Console.WriteLine("enter the qualification");
        string qualification = Console.ReadLine();
        Console.WriteLine("thanks for the info, the details here are as mentioned:\nthe name entered is " + name);
        Console.WriteLine("the age is " + age);
        Console.WriteLine("the qualification of this user is " + qualification);
    }
}
