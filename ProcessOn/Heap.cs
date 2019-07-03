using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessOn
{
    public class Heap<T>:IContainer<T> where T:IComparable
    {
        const int root = 1;
        private int Size { get; set; }
        private T[] Elements { get; }
        public Heap()
        {
            Size = 0;
            Elements = new T[100];
        }
        public void Push(T element)
        {
            Elements[++Size] = element;
            int t = Size;
            while(t > root)
            {
                if (Elements[t].CompareTo(Elements[t >> 1]) < 0)
                {
                    T tmp = Elements[t];
                    Elements[t] = Elements[t >> 1];
                    Elements[t >> 1] = tmp;
                    t >>= 1;
                }
                else
                    break;
            }
        }
        public T Top()
        {
            return Elements[root];
        }
        public T Pop()
        {
            T ret = Elements[root];
            Elements[root] = Elements[Size];
            Elements.SetValue(null, Size--);
            int t = root;
            while((t << 1) <= Size)
            {
                int x = (t << 1 | 1) > Size ? t << 1 : Max(t << 1 | 1, t << 1);
                if (Elements[t].CompareTo(Elements[x]) < 0)
                {
                    T tmp = Elements[t];
                    Elements[t] = Elements[x];
                    Elements[x] = tmp;
                    t = x;
                }
                else
                    break;
            }
            return ret;
        }

        private int Max(int v1, int v2)
        {
            return Elements[v1].CompareTo(Elements[v2]) < 0 ? v2 : v1;
        }

        public List<T> Array()
        {
            return new List<T>(Elements.Take(Size).ToArray());
        }

        public bool IsEmpty()
        {
            return Size == 0;
        }
    }
}
