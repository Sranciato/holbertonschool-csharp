using System;

///<summary>Queue class</summary>
class Queue<T>
{
    Node head;
    Node tail;
    int count;

    ///<summary>Node class</summary>
    public class Node
    {
        public T value;
        public Node next = null;
        public Node(T v)
        {
            value = v;
        }
    }

    ///<summary>creates a new Node and adds it to the end of the queue</summary>
    public void Enqueue(T value)
    {
        Node node = new Node(value);
        if (head == null)
        {
            head = node;
            tail = node;
        }
        else
        {
            tail.next = node;
            tail = node;
        }
        count += 1;
    }

    ///<summary>return the number of nodes in the queue</summary>
    public int Count()
    {
        return count;
    }

    ///<summary>return the queue's type</summary>
    public Type CheckType()
    {
        return typeof(T);
    }

}