using System;
using System.Collections.Generic;

namespace ProcessOn
{
    class PQueue<T> : Queue<T>, IContainer<T> where T : IComparable
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
    }
}
