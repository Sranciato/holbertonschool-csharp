using System;
using System.Collections.Generic;

class Obj
{
    ///<summary>returns true if object is an int</summary>
    public static bool IsOfTypeInt(object obj)
    {
        return obj is int;
    }
}