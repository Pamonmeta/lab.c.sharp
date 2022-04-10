using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorium4
{
    partial class Lista<T>
    {
        private class Node
        {
            public T value { get; set; }
            public Node next;
        }

        private Node first = null;
        private Node last = null;

        private static int count = 0;

        public int Count { get { return count; } }


        public void Add(T element)
        {
            if (first == null)
            {
                first = last = new Node() { value = element };
                count++;
            }
            else
            {
                last = last.next = new Node() { value = element };
                count++;
            }
        }

        public void RemoveAt(int i)
        {
            if (i == 0)
                first = null;
            else
            {
                if(Get(i).next != null)
                {
                    Console.WriteLine($"\nUsuniecie elementu numer {i + 1}");
                    Node tmp = Get(i);
                    Get(i-1).next = Get(i).next;
                    tmp = null;
                }
            }
            count--;
        }

        public void Remove(T element)
        {
            foreach(T e in this)
            {
                if (Equals(element)) { }
                count--;
            }
        }

        public void Insert(int i, T element)
        {
            if(i == 0)
                first.value = element;
            else
            {

            }
            count++;
        }

        private Node Get(int i)
        {
            var e = first;
            while (i-- > 0 && e != null)
                e = e.next;
            if (e == null)
                throw new IndexOutOfRangeException();
            return e;
        }

        public T this[int i] { get => Get(i).value; set => Get(i).value = value; }
    }
}
