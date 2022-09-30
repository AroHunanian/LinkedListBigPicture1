using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListBigPicture
{
    public class LinkedListNode<T>
    {
        public T _value { get; set; }
        public LinkedListNode<T> next { get; set; }
        public LinkedListNode( T value)
        {
            _value = value;
        }
    }
}
