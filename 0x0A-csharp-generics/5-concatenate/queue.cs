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

    ///<summary>concatenates all values in the queue only if the queue is of type String or Char</summary>
    public string Concatenate()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }
        else if (CheckType() != typeof(char) && CheckType() != typeof(string))
        {
            Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
            return null;
        }
        string str = "";
        if (CheckType() == typeof(char))
        {
            while (head != null)
            {
                str += head.value;
                head = head.next;
            }
        }
        if (CheckType() == typeof(string))
        {
            while (head != null)
            {
                str += head.value;
                if (head.next != null)
                    str += " ";
                head = head.next;
            }
        }
        return str;
    }

    ///<summary>prints the queue starting from the head</summary>
    public void Print()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            while (head != null)
            {
                Console.WriteLine(head.value);
                head = head.next;
            }
        }
    }

    ///<summary>returns the value of the first node without removing it</summary>
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
        {
            return head.value;
        }
    }

    ///<summary>deletes the first node in the queue and returns its value</summary>
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
        {
            count -= 1;
            T holdValue = head.value;
            head = head.next;
            return holdValue;
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