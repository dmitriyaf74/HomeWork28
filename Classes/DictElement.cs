using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork28.Classes
{
    internal class DictElement
    {
        private int _key;
        private string _name;
        public DictElement(int key, string value)
        {
            _key = key;
            _name = value;
        }

        public int Key { get { return _key; } }
        public string Name { get { return _name; } }
    }
}
