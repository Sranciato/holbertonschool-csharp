using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        int last = number % 10;
        Console.Write("The last digit of " + number + " is ");
        if (last > 5)
        {
            Console.WriteLine(last + " and is greater than 5");
        }
        else if (last < 6 && last != 0)
        {
            Console.WriteLine(last + " and is less than 6 and not 0");
        }
        else
        {
            Console.WriteLine(last + " and is 0");
        }
    }
}