using System;
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
            newList.Remove(3);
           
        }
    }
}
