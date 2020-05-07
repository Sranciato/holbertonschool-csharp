using System;

///<summary>Obj class</summary>
class Obj
{
    ///<summary>returns true if object is an instance of a class that ingerits from a specified class</summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType);
    }
}