using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myMethod.Stack
{
    public class MyStack<T> :IEnumerable
    {
        private T[] _stackArray;
        private int _top = -1;

        public int MaxSize { get; }

        public MyStack(int size)
        {
            MaxSize = size;
            _stackArray = new T[size];
        }

        public void Push(T item)
        {
            if (_top == MaxSize - 1)
                throw new StackOverflowException("Stack is full");

            _top++;
            _stackArray[_top] = item;
        }

        public T Pop()
        {
            if (_top == -1)
                throw new InvalidOperationException("Stack is empty");

            T item = _stackArray[_top];
            _stackArray[_top] = default(T);
            _top--;

            return item;
        }

        public T Peek => _stackArray[_top];

        public bool IsEmpty => _top == -1;

        public int Count => _top + 1;

        public bool IsFull => _top == MaxSize - 1;

        public void PrintStack()
        {
            for (int i = _top; i >= 0; i--)
            {
                Console.WriteLine(_stackArray[i] + " ");
            }
            Console.WriteLine();
        }


        public IEnumerator<T> GetEnumerator()
        { 
            for (int i = 0; i <= _top; i++)
            {
                yield return _stackArray[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}
