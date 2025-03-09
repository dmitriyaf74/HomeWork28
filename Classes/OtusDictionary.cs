using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeWork28.Classes
{
    internal class OtusDictionary
    {
        private int capacity;
        private int[] array;


        //array  capacity=4
        //Capacity (get; set;)
        //set

        public OtusDictionary()
        {
            capacity = 4;
            array = new int[capacity];
        }


        public int Capacity {
            get 
            {
                return capacity;
            } 
            set
            { 
                capacity = value; 
            }

        }


    }
}
