using System;
using System.Collections.Generic;
using System.Reflection;

///<summary>Base class</summary>
abstract class Base
{
    public string name = "";

    ///<summary>Override ToString method</summary>
    public override string ToString()
    {
        string _string = name + " is a " + this.GetType().Name;
        return _string;
    }
}

///<summary>IInteractive interface</summary>
interface IInteractive
{
    void Interact();
}

///<summary>IBreakable interface</summary>
interface IBreakable
{
    int durability {get; set;}
    void Break();
}

///<summary>ICollectable interface</summary>
interface ICollectable
{
    bool isCollected {get; set;}
    void Collect();
}

///<summary>TestObject class</summary>
class Door : Base, IInteractive
{
    ///<summary>Door constructor</summary>
    public Door(string _name = "Door")
    {
        name = _name;
    }

    public void Interact()
    {
        Console.WriteLine("You try to open the " + name + ". It's locked.");
    }
}

///<summary>Decoration class</summary>
class Decoration : Base, IInteractive, IBreakable
{
    public bool isQuestItem;
    public int durability {get; set;}

    ///<summary>Decoration constructor</summary>
    public Decoration(string _name = "Decoration", int _durability = 1, bool _isQuestItem = false)
    {
        if (_durability <= 0)
            throw new Exception("Durability must be greater than 0");
        name = _name;
        durability = _durability;
        isQuestItem = _isQuestItem;
    }

    public void Interact()
    {
        if (durability <= 0)
            Console.WriteLine("The " + name + " has been broken.");
        else if (isQuestItem)
            Console.WriteLine("You look at the " + name + ". There's a key inside.");
        else
            Console.WriteLine("You look at the " + name + ". Not much to see here.");
    }

    public void Break()
    {
        durability -= 1;
        if (durability > 0)
            Console.WriteLine("You hit the " + name + ". It cracks.");
        else if (durability == 0)
            Console.WriteLine("You smash the " + name + ". What a mess.");
        else
            Console.WriteLine("The " + name + " is already broken.");
    }
}