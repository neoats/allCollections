using CollectionSamples.Queues;

#region queue ctrl+z

/*var queue = new MyQueue<string>();
for (var i = 0; i < 10; i++)
{
    var a = Convert.ToString(Console.ReadLine());
    queue.Enqueue(a);
}

zCheck(true, queue);

static void zCheck(bool isRunning, MyQueue<string> myQueue)
{
    while (isRunning)
    {
        var keyInfo = Console.ReadKey();

        if (keyInfo.Key == ConsoleKey.Z && keyInfo.Modifiers == ConsoleModifiers.Control)
        {
            if (myQueue.IsEmpty)
            {
                Console.WriteLine("Queue is empty!");
                isRunning = false;
            }
            else
            {
                myQueue.Dequeue();
                myQueue.PrintQueue();

                if (myQueue.Count <= 1)
                {
                    Console.WriteLine("Queue is empty!");
                    isRunning = false;
                }
            }
        }
    }
}

Console.ReadLine()*/;

#endregion

#region dictionary

/*myDictionary<int, string> _dictionary = new myDictionary<int, string>();
_dictionary.Add(1, "f");
_dictionary.Add(2, "c");
_dictionary.Add(3, "b");
var myEnumerable = new MyDictionaryEnumerable<int, string>(_dictionary);
foreach (var var in myEnumerable)
{
    Console.WriteLine(var);
}

*/

#endregion

#region stack

/*MyStack<int> stack = new MyStack<int>(10);
stack.Push(1);
stack.Push(2);

stack.Push(3);
stack.Push(4);
stack.PrintStack();
Console.WriteLine();
foreach (var i in stack)
{
    Console.WriteLine(i);  
}

Console.WriteLine();
stack.PrintStack();
Console.WriteLine();
stack.Pop();
foreach (var i in stack)
{
    Console.WriteLine(i);
}

Console.WriteLine();
stack.PrintStack();
*/

#endregion

#region linkedlist

/*LinkedList<object> mylist = new LinkedList<object>();
mylist.AddFirst("old");
mylist.AddFirst("good");
mylist.AddFirst(1);
var goodNode = mylist.Find("good");
mylist.AddAfter(goodNode,"nunliebe");


foreach (var i in mylist)
{
    Console.WriteLine(i);  
}
*/

#endregion