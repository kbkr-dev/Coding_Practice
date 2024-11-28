using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Practice.Practice
{
    public class Node<TValue>
    {
        public TValue Data;
        public Node<TValue> Next;

        public Node(TValue data)
        {
            Data = data;
            Next = null;
        }
    }
    public class CustomLinkedList<TValue>
    {
        private Node<TValue> head;
        private Node<TValue> tail;
        private int length;
        public CustomLinkedList(TValue value)
        {
            head = new Node<TValue>(value);
            tail = head;
            length = 1;
        }

        public void append(TValue value)
        {
            var node = new Node<TValue>(value);
            tail.Next = node;
            tail = node;
            length++;
        }

        public void prepend(TValue value)
        {
            var node = new Node<TValue>(value);
            node.Next = head;
            head = node;
            length++;
        }

        public void insert(int index, TValue value)
        {
            index = WrapIndex(index);

            if (index == 0)
            {
                prepend(value);
                return;
            }

            if (index == length - 1)
            {
                append(value);
                return;
            }

            var node = new Node<TValue>(value);
            var leader = TraverseToIndex(index);
            var holdingPointer = leader.Next;

            leader.Next = node;
            node.Next = holdingPointer;

            length++;
        }

        public void remove(int index)
        {
            index = WrapIndex(index);

            if (index == 0)
            {
                head = head.Next;
                return;
            }

            var leader = TraverseToIndex(index);
            var removePointer = leader.Next;
            leader.Next = removePointer.Next;
            length--;
        }

        public void reverse()
        {
            Node<TValue> preNode = null;
            Node<TValue> currentNode = head;
            Node<TValue> nextNode = null;

            while(currentNode != null)
            {
                nextNode = currentNode.Next;
                currentNode.Next = preNode;
                preNode = currentNode;
                currentNode = nextNode;
            }

            head = preNode;
        }


        private int WrapIndex(int index)
        {
            return Math.Max(Math.Min(index, length - 1), 0);
        }

        private Node<TValue> TraverseToIndex(int index)
        {
            int counter = 0;

            index = WrapIndex(index);
            var currentNode = head;

            while (counter != index)
            {
                currentNode = currentNode.Next;
                counter++;
            }

            return currentNode;
        }

    }
}
