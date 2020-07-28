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
class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability {get; set;}
    public bool isCollected {get; set;}

    public void Interact()
    {
    }

    public void Break()
    {
    }

    public void Collect()
    {
    }
}