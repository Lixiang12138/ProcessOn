using System;

namespace ProcessOn
{
    interface IContainer<T> where T : IComparable
    {
        T Top();
        void Push(T process);
        T Pop();
        T[] Array();
        bool IsEmpty();
    }
}
