using System;
using System.Collections.Generic;

///<summary>returns true if is instance of a class</summary>
class Obj
{
    ///<summary>returns true if is instance of a class</summary>
    public static bool IsInstanceOfArray(object obj)
    {
        return obj is Array;
    }
}