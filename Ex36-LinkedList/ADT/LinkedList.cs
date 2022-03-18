using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADT
{
    public class LinkedList
    {
        private class Node
        {
            public object Data { get; set; }
            public Node Next { get; set; }

            public override string ToString()
            {
                return Data.ToString();
            }
        }

        private Node head = new();
        private int count = 0;
        public int Count{ get { return count; } }

        public void InsertAt(int index, object o)
        {
            if (index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            if (index >= Count)
            {
                index = Count - 1;
            }

            Node current = head;

            if (index == 0)
            {
                head = new Node();
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                    current.Next = new Node();
                }
            }
            count++;
            current.Data = o;
        }

        public void DeleteAt(int index)
        {
            if (index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            if (index >= Count)
            {
                index = Count - 1;
            }

            Node current = head;
            object empty = null;

            if (index == 0)
            {
                empty = current.Data;
                head = current.Next;
            }
            else
            {
                for (int i = 0; index < index - 1; i++)
                {
                    current = current.Next;
                }
                empty = current.Next.Data;
                current.Next = current.Next.Next;
            }
            count--;
        }

        public object ItemAt(int index)
        {
            if (index < 0)
            {
                throw new IndexOutOfRangeException("Index: " + index);
            }

            if (index >= Count)
            {
                index = Count - 1;
            }

            Node current = head;

            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }

            return current.Data;
        }

        public override string ToString()
        {
            return head.ToString();
        }
    }
}
