using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication11
{
    class Queue
    {
        Element[] q = new Element[1000];
        int iter;
        public Queue()
        {
            iter = -1;
        }

        public void Clear()
        {
            iter = -1;
        }

        public bool IsEmpty()
        {
            return iter == -1;
        }

        public bool IsFull()
        {
            return iter == 1000;
        }

        public int GetCount()
        {
            return iter + 1;
        }

        public Element Remove()
        {
            if (IsEmpty())
                return new Element();

            return q[iter--];
        }

        public void Print()
        {
            if (IsEmpty())
                return;

            for (int i = iter; i >= 0; i--)
            {
                Console.Write("{0\t}", q[i].Data);
            }
        }

        public void PrintWithPriority()
        {
            if (IsEmpty())
                return;

            for (int i = iter; i >= 0; i--)
                Console.Write("{0},pr:{1}\n", q[i].Data, q[i].priority);
        }

        public void Add(Element elem)
        {
            int i;
            for (i = iter; i >= 0; i--)
                if (q[i].priority > elem.priority)
                    break;
            if (IsFull())
            {
                if (i != -1)
                {
                    for (int j = 0; j < i; j++)
                        q[j] = q[j + 1];
                    q[i] = elem;
                }
            }
            else
            {
                for (int j = iter; j > i; j--)
                    q[j + 1] = q[j];
                 q[i + 1] = elem;
                 iter++;
            }
        }
    }
}
