using System;

class Program
{
    static void Main(string[] args)
    {
        Door frontDoor = new Door("Back Door");

        Console.WriteLine(frontDoor.ToString());

        frontDoor.Interact();
    }
}