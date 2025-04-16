using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using HomeWork28.Exceptions;
using HomeWork28.Interfaces;
using Microsoft.VisualBasic;
using static System.Math;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HomeWork28.Classes
{
    internal class OtusDictionary : IMyList
    {
        private int _size;
        private DictElement[] _array;
        public int Capacity { get { return _array.Length; } }

        public OtusDictionary()
        {
            _size = 0;
            _array = new DictElement[32];
        }

        public int Size { get { return _size; } }

        
        private void Grow(int NewSize)
        {
            if (NewSize > _array.Length)
            {
                int newCapacity = Max(NewSize, _array.Length * 2);

                DictElement[] newArray = new DictElement[newCapacity];
                for (int i = 0; i < _array.Length; i++)
                {
                    if (_array[i] is not null)
                    {
                        DictElement de = _array[i];
                        var index = de.Key;
                        index = index % newCapacity;
                        newArray[index] = de;
                    }
                }
                _array = newArray;
            }
        }


        public void Add(int key, string value)
        {
            if (_size == _array.Length)
            {
                Grow(_size + 1);
            }

            DictElement de = new(key, value);
            var index = key % Capacity;
            while (_array[index]?.Key is not null)
            {
                Grow(_array.Length + 1);
                index = key % Capacity;
            }
            _array[index] = de;
            _size++;
        }

        public string HachSearchStr(int key)
        {
            int index = key % Capacity;
            int startIndex = index; 

            while (_array[index] != null)
            {
                if (_array[index].Key == key)
                {
                    return _array[index].Name; 
                }

                index = (index + 1) % Capacity; 

                if (index == startIndex)
                {
                    return null; 
                }
            }

            return null; 
        }

        public string Get(int key)
        {
            var resStr = HachSearchStr(key);
            if (resStr != null)
                return resStr;
            throw new EKeyNotFound($"Ключ не найден {key}");
        }

        public DictElement IndexOf(int index)
        {
            return _array[index];
        }

        public string this[int index]
        {
            get
            {
                return Get(index);
            }

        }
    }
}
