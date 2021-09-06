using System;
public class Sample
{
    public static void Main()
    {
        Console.Write("enter the amount of celcius:");
        int celcius = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("kelvin ={0}", celcius + 273);
        Console.WriteLine("Farenheit = {0}", celcius * 18 / 10 + 32);
    }
}

