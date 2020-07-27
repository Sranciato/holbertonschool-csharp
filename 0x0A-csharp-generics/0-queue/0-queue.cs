using System;

///<summary>Queue class</summary>
public class Queue<T>
{
    ///<summary>return the queue's type</summary>
    public Type CheckType()
    {
        return typeof(T);
    }
}