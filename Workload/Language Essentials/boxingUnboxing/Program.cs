using System;
using System.Collections.Generic;

namespace boxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> myList = new List<object>();
            myList.Add(7);
            myList.Add(28);
            myList.Add(-1);
            myList.Add(true);
            myList.Add("chair");
            int sum = 0;
            foreach (object item in myList)
            {
                System.Console.WriteLine(item);
                if (item is int)
                {
                    sum = sum + (int)item;
                }
            }
            System.Console.WriteLine(sum);
        }
    }
}
