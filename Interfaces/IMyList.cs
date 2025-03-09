using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork28.Interfaces
{
    internal interface IMyList
    {
        public void Add(int key, string value);
        public string Get(int key);
    }
}
