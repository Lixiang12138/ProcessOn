using System;
using System.Collections.Generic;

namespace ProcessOn
{
    internal class PQueue<T> : Queue<T>, IContainer<T> where T : IComparable
    {
        public T Pop()
        {
            return Dequeue();
        }

        public void Push(T obj)
        {
            Enqueue(obj);
        }

        public T Top()
        {
            return Peek();
        }

        public List<T> Array()
        {
            return new List<T>(ToArray());
        }

        public bool IsEmpty()
        {
            return Count == 0;
        }
    }
}
