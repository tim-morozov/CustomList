﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> newList = new CustomList<int>();
            newList.Add(4);
            newList.Add(3);
            newList.Add(1);
            newList.Add(6);
            newList.Add(9);
            //newList.Add(1);
            //newList.Add(3);
            //newList.Add(5);
            CustomList<int> newList2 = new CustomList<int>();
            newList2.Add(4);
            newList2.Add(2);
            newList2.Add(3);
            newList2.Add(8);
            newList2.Add(5);
            //newList2.Add(2);
            //newList2.Add(4);
            //newList2.Add(6);

            //string str = newList.ToString();
            

            CustomList<int> newList3 = new CustomList<int>();
            //newList3 = newList + newList2;
            newList3 = newList - newList2;
            //newList3 = newList.Zip(newList, newList2);
           
        }
    }
}
