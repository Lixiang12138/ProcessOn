﻿using System;
using System.Collections.Generic;

namespace ProcessOn
{
    interface IContainer<T> where T : IComparable
    {
        T Top();
        void Push(T process);
        T Pop();
        List<T> Array();
        bool IsEmpty();
    }
}
