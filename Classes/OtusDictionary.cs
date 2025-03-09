using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using HomeWork28.Exceptions;
using HomeWork28.Interfaces;
using static System.Math;

namespace HomeWork28.Classes
{
    internal class OtusDictionary: IMyList
    {
        private int _capacity;
        private int _size;
        private DictElement[] _array;
        public int Capacity {  get { return _capacity; } }

        public OtusDictionary()
        {
            _size = 0;
            _capacity = 32;
            _array = new DictElement[_capacity];
        }

        public int Size
        {
            get
            {
                return _size;
            }
            set
            {
                if (_size != value)
                {
                    if (value < 0)
                    {
                        _size = 0;
                        return;
                    }
                    else
                    if (value > _capacity)
                    {
                        Grow(_size + 1);
                    }
                    _size = value;

                }
            }

        }

        private void Grow(int NewCapacity)
        {
            if (NewCapacity <= _capacity) 
            {
                return;
            }
            int newCapacity = Max(_capacity, 2);
            newCapacity = Max(newCapacity, _capacity * 2);

            DictElement[] newArray = new DictElement[newCapacity];
            for (int i = 0; i < _capacity; i++)
            {
                if (_array[i] is not null)
                {
                    DictElement de = _array[i];
                    var index = de.GetHashCode();
                    index = index % newCapacity;
                    newArray[index] = de;
                }
            }
            _array = newArray;
            _capacity = newCapacity;
        }

        public void Add(int key, string value)
        {
            Size = _size + 1;
            DictElement de = new(key, value);
            var index = de.GetHashCode();
            index = index % _capacity;
            while (_array[index]?.Key is not null)
            {
                Grow(_capacity + 1);
                index = de.GetHashCode() % _capacity;
            }
            _array[index] = de;
        }

        public string Get(int key)
        {
            for (int i = 0; i < _capacity; i++)
            {
                if (_array[i]?.Key == key)
                {
                    return _array[i].Name;
                }
            }
            throw new EKeyNotFound($"Ключ не найден {key}");
        }

        public DictElement IndexOf(int index)
        {
            return _array[index];
        }
    }
}
