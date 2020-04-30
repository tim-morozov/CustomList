using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
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
                if(index < 0 && index > capacity)
                {
                    throw new IndexOutOfRangeException("Index out of range");   
                }
                return items[index];
            }
            set
            {
                if (index < 0 && index > capacity)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
                items[index] = value;
            }
        }

        public void Add(T item)
        {
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
            items[count] = item;
            count++;
        }

        public void Remove(T item)
        {
            T[] newArray = new T[capacity + 1];
            int index;
           
           index = Find(item);
            if (index == capacity + 1)
            {
                count = count;
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    if (i == index)
                    {
                        newArray[index] = items[i + 1];

                    }
                    else if (i > index)
                    {
                        newArray[i] = items[i + 1];
                    }
                    else
                    {

                        newArray[i] = items[i];

                    }
                }

                items = newArray;
                count--;
            }
        }

        public int Find(T item)
        {
            int index = -1;
            int i;
            for ( i = 0; i < count; i++)
            {
                if (items[i].Equals(item))
                {     
                     index = i;
                }                
            }
            if (index == -1)
            {
                return capacity + 1;
            }
            else
            {
                return index;
            }
        }

        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }

        public override string ToString()
        {
            string newString = string.Empty;
            foreach (T item in this)
            {
                if (string.IsNullOrEmpty(newString))
                {
                    newString += item.ToString();
                }
                else
                {
                    newString += ", " + item.ToString();
                }
            }
            return newString;
        }

        public static CustomList<T> operator+(CustomList<T> a, CustomList<T> b)
        {
            CustomList<T> newList = new CustomList<T>();
            for (int i = 0; i < a.count; i++)
            {
                newList.Add(a[i]);
            }
            for(int i = 0; i < b.count; i++)
            {
                newList.Add(b[i]);
            }

            return newList;
        }

        public static CustomList<T> operator-(CustomList<T> a, CustomList<T> b)
        {
            CustomList<T> newList = new CustomList<T>();
            for(int i = 0; i < a.count; i++)
            {
                for(int j = 0; j < b.count; j++)
                {
                    if(a[i].Equals(b[j]))
                    {
                        a.Remove(a[i]);
                        b.Remove(b[j]);
                    }
                   
                }
            }
            newList = a + b;
           
            return newList; 
        }

        public CustomList<T> Zip(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> newList = new CustomList<T>();
            
            for(int i = 0; i < list1.count; i++)
            {
                newList.Add(list1[i]);
                newList.Add(list2[i]);
            }
            return newList;
        }
    }
}
