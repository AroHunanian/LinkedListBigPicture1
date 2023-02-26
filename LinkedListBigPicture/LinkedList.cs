using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListBigPicture
{
    internal class LinkedList<T> : ICollection<T>,IEnumerable<T>
    {
        public LinkedListNode<T> head { get; private set; }
        public LinkedListNode<T> tail { get; private set; }
        public void Print(LinkedListNode<T> node)
        {
            Console.WriteLine(node._value);
        }
        public void PrintAll(LinkedListNode<T> node)
        {


            while (node != null)
            {
                Print(node);
                node = node.next;
            }


        }
        #region ICollection
        public int Count { get; private set; }
        public bool IsReadOnly => false;

        public void Clear()
        {
            head = null;
            tail = null;
            Count = 0;
        }
        public bool Contains(T item)
        {
            LinkedListNode<T> current = head;
            while (current != null)
            {
                if (current._value.Equals(item))
                    return true;
                current = current.next;
            }
            return false;
        }

        public void Add(T item)
        {
            AddFirst(item);
        }
        #endregion
        #region Add
        public void AddFirst(T item)
        {
            AddFirst(new LinkedListNode<T>(item));
        }
        private void AddFirst(LinkedListNode<T> node)
        {
            LinkedListNode<T> temp = head;
            head = node;
            head.next = temp;
            Count++;
            if (Count == 1)
            {
                tail = head;
            }
        }

        #endregion
        #region AddLast
        public void AddLast(T item)
        {
            AddLast(new LinkedListNode<T>(item));
        }
        private void AddLast(LinkedListNode<T> node)
        {
            if (Count == 0)
                head = node;
            else
                tail.next = node;
            tail = node;
            Count++;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {

            LinkedListNode<T> current = head;
            while (current != null)
            {
                array[arrayIndex++] = current._value;
                current = current.next;
            }


        }

        public bool Remove(T item)
        {
            LinkedListNode<T> current = head;
            LinkedListNode<T> prev = null;
            while (current != null)
            {
                if (current._value.Equals(item))
                {
                    if (prev != null)
                    {
                        if (tail == current)
                        {
                            tail = prev;
                        }
                        else
                        {
                            prev.next = current.next;
                        }
                    }
                    else
                    {
                        head = null;
                        tail = null;
                    }
                    return true;
                }
                prev = current;
                current = current.next;
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> node = head;
            while (node != null)
            {
                yield return node._value;

            }
            node = node.next;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        
        #endregion
    }
}
