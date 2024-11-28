using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Practice.Practice
{
    public class DoubleNode<TValue>
    {
        public TValue Data;
        public DoubleNode<TValue> Next;
        public DoubleNode<TValue> Pre;

        public DoubleNode(TValue value)
        {
            Data = value;
            Next = null;
            Pre = null;
        }
    }
    public class CustomDoubleLinkedList<TValue>
    {
        private DoubleNode<TValue> head;
        private DoubleNode<TValue> tail;
        private int length = 0;

        public CustomDoubleLinkedList(TValue value)
        {
            var node = new DoubleNode<TValue>(value);
            head = node;
            tail = node;
            length++;
        }

        public void prepend(TValue value)
        {
            var newNode = new DoubleNode<TValue>(value);

            newNode.Next = head;
            head.Pre = newNode;
            head = newNode;
        }

        public void append(TValue value)
        {
            var newNode = new DoubleNode<TValue>(value);
            tail.Next = newNode;
            newNode.Pre = tail;
            tail = newNode;
        }

        public bool Remove(TValue value)
        {
            var curr = head;
            while (curr != null)
            {
                if(EqualityComparer<TValue>.Default.Equals(curr.Data, value))
                {
                    if(curr.Pre != null)
                    {
                        curr.Pre.Next = curr.Next;
                    }
                    else
                    {
                        head = curr.Next;
                    }

                    if(curr.Next != null)
                    {
                        curr.Next.Pre = curr.Pre;
                    }
                    else
                    {
                        tail = curr.Pre;
                    }

                    return true;
                }

                curr = curr.Next;
            }

            return false;
        }
    }
}
