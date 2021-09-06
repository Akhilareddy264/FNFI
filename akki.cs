using System;
public class RealNumbers
{
    public static void Main()
    {
        int i, n, sum = 0;
        double avg;
        Console.Write("\n\n");
        Console.Write("read 10 numbers and calculate sum and average:\n");
        Console.Write("-----");
        Console.Write("\n\n");
        Console.Write("input the 10 number:\n");
        for (i = 1; i <= 10; i++)
        {
            Console.Write("number-{0} :", i);
            n = Convert.ToInt32(Console.ReadLine());
            sum += n;
        }
        avg = sum / 10.0;
        Console.Write("the sum of 10 no is : {0}\nThe Average is : {1}\n", sum, avg);

    }
   
    }

