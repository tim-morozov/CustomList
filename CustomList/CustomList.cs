using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
   public class CustomList<T>
    {
        private T[] items;
        private int count;
        private int capacity;
        public int Count
        {
            get
            {
                return count;
            }
        }
        public int Capacity
        {
            get
            {
                return capacity;
            }
        }


        public CustomList()
        {
            items = new T[4];
            count = 0;
            capacity = 0;
        }

        public void Add(T item)
        {

        }

        public void Remove(T item)
        {

        }
    }
}
