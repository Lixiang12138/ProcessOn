using System;

namespace ProcessOn
{
    interface IContainer
    {
        Process Top();
        void Push(Process process);
        void Pop();
        bool Contains(String name);
        Process Get(String name);
    }
}
