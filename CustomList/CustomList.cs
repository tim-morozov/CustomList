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
        private int Count;
        private int Capacity;

        public CustomList()
        {
            items = new T[4];
            Count = 0;
            Capacity = 0;
        }

        public void Add(T item)
        {

        }

        public void Remove(T item)
        {

        }
    }
}
