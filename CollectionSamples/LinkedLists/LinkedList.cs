using System.Collections;

namespace CollectionSamples.LinkedLists;

class Node<T>
{
    public Node(T data)
    {
        Data = data;
        Next = null;
    }

    public T Data { get; set; }
    public Node<T> Next { get; set; }
}

class myLinkedList<T> : IEnumerable<T>
{
    Node<T> head;

    public myLinkedList()
    {
        head = null;
    }

    public IEnumerator<T> GetEnumerator()
    {
        var current = head;

        while (current != null)
        {
            yield return current.Data;
            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(T data)
    {
        var newNode = new Node<T>(data);

        if (head == null)
        {
            head = newNode;
            return;
        }

        var current = head;

        while (current.Next != null) current = current.Next;

        current.Next = newNode;
    }

    public void Print()
    {
        var current = head;

        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        }

        Console.WriteLine();
    }
}