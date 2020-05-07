using System;
using System.Collections.Generic;
using System.Reflection;

///<summary>Obj Class</summary>
class Obj
{
    ///<summary>prints the name of the available properties and methods of an object</summary>
    public static void Print(object myObj)
    {
        TypeInfo t = myObj.GetType().GetTypeInfo();
        Console.WriteLine(t.Name + " Properties:");
        foreach (PropertyInfo p in t.GetProperties())
        {
            Console.WriteLine(p.Name);
        }
        Console.WriteLine(t.Name + " Methods:");
        foreach (MethodInfo m in t.GetMethods())
        {
            Console.WriteLine(m.Name);
        }
    }
}