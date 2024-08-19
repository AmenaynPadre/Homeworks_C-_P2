using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyStack
{
    public class MyStack<T> : ICollection, IEnumerable<T>, IEnumerable
    {
        private T[] _items;
        private int _count;
        private int _defaultCapacity = 4;

        public MyStack()
        {
            _items = new T[_defaultCapacity];
        }
        public MyStack(int capacity)
        {
            Capacity = capacity;
            _items = new T[Capacity];
        }
        //public MyStack() 
        //{ 

        //}

        public int Count { get => _count; }

        public int Capacity { get; set; }

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        //public T Pop() 
        //{

        //}
        public bool TryPop() { throw new NotImplementedException(); }

        public void Push(T item)
        {
            if (_count == _items.Length)
            {
                Resize(_items.Length * 2);
            }
            _items[_count++] = item;
        }

        public bool TryPeek(out T result)
        {
            if (_count == 0)
            {
                result = default;
                return false;
            }
            result = _items[_count - 1];
            return true;
        }

        public T Peek()
        {
            if (_count == 0)
            {
                throw new Exception("Stack is empty");
            }
            return _items[_count - 1];
        }

        public bool Contains(T item)
        {
            return _items.Contains(item);
        }

        public void Clear()
        {
            Array.Clear(_items, 0, _count);
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        private void Resize(int newSize)
        {
            T[] newArray = new T[newSize];
            Array.Copy(_items, newArray, _count);
            Capacity = newSize;
            _items = newArray;
        }


        public IEnumerator<T> GetEnumerator()
        {
            for (int i = _count - 1; i >= 0; i--)
            {
                yield return _items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
