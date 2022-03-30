using System;
using System.Collections.Generic;
using System.Text;

namespace CL.Models
{
    internal class CustomList<T>
    {
        private T[] _list = new T[1];
        public int Count { get; private set; }
        public int Capacity { get; }
        public Type Typeof
        {
            get
            { return typeof(T); }
        }
       
        public T this[int index]
        {
            get { return _list[index]; }
            set { _list[index] = value; }
        }
        public CustomList(int capacity)
        {
            Capacity = capacity;
        }
        public CustomList()
        {
            Capacity = int.MaxValue;
        }

        public void Add(T input)
        {
        Point:
            if (_list[_list.Length - 1] == null)
            {
                _list[Count] = input;
                Count++;
                Console.WriteLine("Added");
            }
            else
            {
                if (_list.Length * 2 > Capacity) throw new Exception("Capacity OverFlow");
                Array.Resize(ref _list, _list.Length * 2);
                Console.WriteLine($"Resized, {_list.Length} Length , {Count + 1} Current");
                goto Point;
            }
        }
        public void Reverse()
        {
            Array.Reverse(_list);
            //T temp;
            //for (int i = 0; i < _list.Length / 2; i++)
            //{
            //    temp = _list[i];
            //    _list[i] = _list[_list.Length - i - 1];
            //    _list[_list.Length - i - 1] = temp;
            //}
        }
        public void Clear()
        {
            Array.Resize(ref _list, 2);
            _list[0] = default;
            _list[1] = default;
            Count = 0;
        }
        public bool Exist(T value)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_list[i].Equals(value))
                {
                    return true;
                }
            }
            return false;
        }
        public void Remove(T value)
        {
            int index = IndexOf(value);
            RemoveAt(index);
        }
        public void RemoveAt(int index)
        {
            if (index < _list.Length)
            {
                for (int i = index; i < _list.Length - 1; i++)
                {
                    _list[i] = _list[i + 1];
                }
                _list[_list.Length - 1] = default;
            }
        }

        public int IndexOf(T value)
        {
            for (int i = 0; i < _list.Length - 1; i++)
            {
                if (_list[i].Equals(value))
                    return i;
            }
            return -1;
        }
        public int LastIndexOf(T value)
        {
            for (int i = _list.Length - 1; i >= 0; i--)
            {
                if (_list[i].Equals(value)) return i;
            }
            return -1;
        }
        public void ShowInfo()
        {
            foreach (var item in _list)
                if(item!=null)
                    Console.WriteLine(item);
        }
    }
}
