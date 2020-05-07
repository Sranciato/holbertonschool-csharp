using System;

///<summary>Shape Class</summary>
class Shape
{
    ///<summary>throws not implemented exception</summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}