using System.Collections;

namespace CollectionSamples.Queues;

public class MyQueue<T>
{
    private readonly List<T> _queueList = new List<T>();
    int _front;
    int _rear=-1;


   
    public void Enqueue(T item)
    {
        _rear++;
        _queueList.Add(item);
    }

    public T Dequeue()
    {
        var temp = _queueList[_front];
        _front++;
        if(_front >= _queueList.Count) _front = 0;
        return temp;
    }
    public bool IsEmpty => _rear < _front;
    public bool IsFull => _rear == _queueList.Count - 1;
    public int Count => _rear - _front + 1;

    public void PrintQueue()
    {
        Console.WriteLine();
        for (var i = _front; i <= _rear; i++)
            Console.WriteLine(_queueList[i] + " ");
     
    }



}