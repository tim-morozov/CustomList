using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
   public class CustomList<T> : IEnumerable
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
            capacity = 4;
        }
        //Indexer    
        public T this[int index]
        {
            get
            {
                if(index < 0 && index >= capacity)
                {
                    throw new IndexOutOfRangeException("Index out of range");   
                }
                return items[index];
            }
            set
            {
                if (index < 0 && index >= capacity)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
                items[index] = value;
            }
        }

        public void Add(T item)
        {
            items[count] = item;
            count++;
            if(count >= capacity)
            {
                T[] newArray = new T[capacity * 2];
                for(int i = 0; i < count; i++)
                {
                    newArray[i] = items[i];
                }
                items = newArray;
                capacity *= 2;
            }
           
        }

        public void Remove(T item)
        {
            T[] newArray = new T[capacity];
            for(int i = 0; i < count; i++)
            {
                if(items[i] == item)
                newArray[i] = items[i];
                
               
            }
            items = newArray;
            count--;
        }

        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }
    }
}
