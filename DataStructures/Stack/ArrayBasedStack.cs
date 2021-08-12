using System;
using System.Collections.Generic;

namespace DataStructures.Stack
{
    public class ArrayBasedStack<T>
    {
        private const int DefaultCapacity = 10;
        private const string StackEmptyErrorMessage = "Stack is empty";

        private T[] stack;
        private int top;

        public ArrayBasedStack()
        {
            stack = new T[DefaultCapacity];
            top = -1;
        }

        public ArrayBasedStack(T item) 
            : this() => Push(item);

        public ArrayBasedStack(IEnumerable<T> items)
            : this()
        {
            foreach (var item in items)
            {
                Push(item);
            }
        }

        public int Top => top;

        public int Capacity
        {
            get => stack.Length;
            set => Array.Resize(ref stack, value);
        }

        public void Clear()
        {
            top = -1;
            Capacity = DefaultCapacity;
        }

        public bool Contains(T item) => Array.IndexOf(stack, item, 0, top + 1) > -1;

        public T Peek()
        {
            if (Top == -1)
            {
                throw new InvalidOperationException(StackEmptyErrorMessage);
            }

            return stack[top];
        }
        public T Pop()
        {
            if (Top == -1)
            {
                throw new InvalidOperationException(StackEmptyErrorMessage);
            }

            return stack[top--];
        }

        public void Push(T item)
        {
            if (Top == Capacity - 1)
            {
                Capacity *= 2;
            }

            stack[++top] = item;
        }
    }
}
