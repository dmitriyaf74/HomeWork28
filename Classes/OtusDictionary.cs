using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using HomeWork28.Exceptions;
using HomeWork28.Interfaces;
using static System.Math;

namespace HomeWork28.Classes
{
    struct DictElement
    {
        public int Key;
        public string Name;

        public DictElement(int key, string name) : this()
        {
            Key = key;
            this.Name = name;
        }
    }

    internal class OtusDictionary: IMyList
    {
        private int _capacity;
        private int _size;
        private DictElement[] _array;

        public OtusDictionary()
        {
            _size = 0;
            _capacity = 1;
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
                newArray[i] = _array[i];
            }
            _array = newArray;
            _capacity = newCapacity;
        }

        public void Add(int key, string value)
        {
            Size = _size + 1;
            _array[_size - 1] = new(key, value);
        }

        public string Get(int key)
        {
            for (int i = 0; i < _size; i++)
            {
                if (_array[i].Key == key)
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
