using System;
class DateTime
{
    static void Main(string[] args)
    {
        int value1 = 234;
        int value2 = 555;
        int comparision = value1.CompareTo(value2);
        if (comparision == 0)
        {
            Console.WriteLine("they are equal");
        }
        else if (comparision < 0)
            Console.WriteLine("value 1 is lesser than value 2");
        else
            Console.WriteLine("value 1 is greater than value 2");
    }

        }

