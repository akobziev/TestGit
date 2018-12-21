using System;
using System.Collections.Generic;

namespace WorkWIthLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<int> list = new List<int>();
            Console.WriteLine(list.Capacity);

            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            Console.WriteLine(list.Capacity);

            list.Add(1);
            Console.WriteLine(list.Capacity);

            list.AddRange(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine(list.Capacity);
            list.RemoveAll(el => el != 0);
            Console.WriteLine(list.Capacity);

        }
    }

    class MyList
    {
        int[] array = new int[4];

        int lastIndex = 0;
        public void Add(int n)
        {
            if (lastIndex == array.Length - 1)
            {
                int[] newArray = new int[array.Length + 1];
                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = array[i];
                }
                array = newArray;
            }
            array[++lastIndex] = n;
        }
    }
}
