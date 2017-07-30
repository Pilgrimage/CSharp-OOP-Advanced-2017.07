namespace p09_LinkedListTraversal.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class MyLinkedList<T> : IEnumerable<T>
        where T : IComparable
    {
        public MyLinkedList()
        {
            this.Head = null;
            this.Count = 0;
        }

        public Node<T> Head { get; private set; }
        public int Count { get; private set; }

        public void AddLast(T element)
        {
            if (this.Count == 0)
            {
                this.Head = new Node<T>(element);
            }
            else
            {
                Node<T> lastNode = this.GetElementAt(this.Count - 1);
                lastNode.Next = new Node<T>(element);
            }
            this.Count++;
        }

        public void Remove(T element)
        {
            int index = this.GetIndexOf(element);

            if (index == 0)
            {
                this.Head = this.Head.Next;
                this.Count--;
            }
            else if (index > 0)
            {
                Node<T> previousNode = this.GetElementAt(index - 1);
                Node<T> currentNode = this.GetElementAt(index);
                previousNode.Next = currentNode.Next;
                this.Count--;
            }

        }

        public int GetIndexOf(T element)
        {
            Node<T> currentNode = this.Head;

            for (int i = 0; i < this.Count; i++)
            {
                if (currentNode.Value.Equals(element))
                {
                    return i;
                }
                currentNode = currentNode.Next;
            }
            return -1;
        }

        private Node<T> GetElementAt(int index)
        {
            Node<T> currentElement = this.Head;
            for (int i = 0; i < index; i++)
            {
                currentElement = currentElement.Next;
            }

            return currentElement;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> currentNode = this.Head;
            while (currentNode != null)
            {
                yield return currentNode.Value;
                currentNode = currentNode.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}