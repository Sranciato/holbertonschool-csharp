using System;

class Program
{
    static void Main(string[] args)
    {
        Decoration coffeeMug = new Decoration("Coffee Mug", 1, true);

        Console.WriteLine(coffeeMug.ToString());

        coffeeMug.Interact();
        coffeeMug.Break();
        coffeeMug.Break();
        coffeeMug.Interact();
    }
}