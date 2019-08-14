using System;
using System.Collections.Generic;
using System.Text;

namespace CustomLinkedList
{
    public class DoublyLinkedList<T>
        where T : IComparable<T>
    {
        private class LinkNode
            
        {
            public LinkNode(T value)
            {
                Value = value;
            }
            public T Value { get; }
            public LinkNode NextNode { get; set; }
            public LinkNode PreviousNode { get; set; }
        }

        private LinkNode head;

        private LinkNode tail;
        public int Count { get; private set; }
        public void AddFirst(T value)
        {
            LinkNode newHead = new LinkNode(value);

            if (Count == 0)
            {
                tail = head = newHead;
            }
            else
            {
                newHead.NextNode = head;
                head.PreviousNode = newHead;
                head = newHead;
            }

            Count++;
        }
        public void AddLast(T value)
        {
            LinkNode newTail = new LinkNode(value);

            if (Count == 0)
            {
                tail = head = newTail;
            }
            else
            {
                newTail.PreviousNode = tail;
                tail.NextNode = newTail;
                tail = newTail;
            }

            Count++;
        }
        public T RemoveFirst()
        {
            CheckIfEmptyThrowException();

            T firstElement = head.Value;

            head = head.NextNode;

            if (head == null)
            {
                tail = null;
            }
            else
            {
                head.PreviousNode = null;
            }

            Count--;

            return firstElement;
        }
        public T RemoveLast()
        {
            CheckIfEmptyThrowException();

            T lastElement = tail.Value;
            tail = tail.PreviousNode;

            if (tail == null)
            {
                head = null;
            }
            else
            {
                tail.NextNode = null;
            }

            Count--;

            return lastElement;
        }
        public void Print(Action<T> action)
        {
            LinkNode currentNode = head;
            while (currentNode != null)
            {
                action(currentNode.Value);

                currentNode = currentNode.NextNode;
            }
        }
        public bool Contains(T value)
        {
            LinkNode currentNode = head;

            while (currentNode != null)
            {
                if (currentNode.Value.CompareTo(value) == 0)
                {
                    return true;
                }

                currentNode = currentNode.NextNode;
            }

            return false;
        }
        public T[] ToArray()
        {
            T[] array = new T[Count];

            var currentNode = head;
            int counter = 0;

            while (currentNode != null)
            {
                array[counter++] = currentNode.Value;

                currentNode = currentNode.NextNode;
            }

            return array;
        }
        public List<T> ToList()
        {
            List<T> list = new List<T>(Count);

            var currentNode = head;

            while (currentNode != null)
            {
                list.Add(currentNode.Value);

                currentNode = currentNode.NextNode;
            }

            return list;
        }
        private void CheckIfEmptyThrowException()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException
                    ("DoublyLinkedList is empty!");
            }
        }
    }
}
