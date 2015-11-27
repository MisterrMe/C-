using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication11
{
    struct Element
    {
        public char Data;
        public short priority;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
 
            Element[] s = new Element [5];
            s[0].Data = 'A';
            s[0].priority = 1;
            s[1].Data = 'B';
            s[1].priority = 2;
            s[2].Data = 'C';
            s[2].priority = 12;
            s[3].Data = 'D';
            s[3].priority = 3;
            s[4].Data = 'E';
            s[4].priority = 2;

            int len = 5;

            for (int i = 0; i < len; i++)
            {
                q.Add(s[i]);
            }
            q.PrintWithPriority();
            Console.Read();
 
            Element el;
            el.Data = 'P';
            el.priority = 11;
 
            q.Add(el);
 
            q.PrintWithPriority();
            Console.Read();
            Console.Read();
        }
    }
}
