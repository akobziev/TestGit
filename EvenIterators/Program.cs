using HomeTasks;
using System;
using System.Collections;
using System.Collections.Generic;

namespace EvenIterators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //WorkWithIterators();

            //ICollection<int> collection = new int[10];
            //Console.WriteLine(collection.Count);

            //int[] test = new int[120];

            Console.WriteLine(FindLast(new string[] { "Vasa", "Test" }, el => el.Contains("a")));
            Console.WriteLine(TrueForAll(new string[] { "Vasa", "Test" }, el => el.Contains("s")));

        }

        private static bool TrueForAll<T>(T[] array, Predicate<T> predicate)
        {
            bool res = false;
            foreach (var el in array)
            {
                res = predicate(el);
            }

            return res;
        }

        private static T FindLastIndex<T>(T[] array, Predicate<T> predicate)
        {


            return default(T);
        }

        private static T FindLast<T>(T[] array, Predicate<T> predicate)
        {
            foreach (var el in array)
            {
                if (predicate(el))
                {
                    return el;
                }
            }
            return default(T);
        }

        private static void WorkWithIterators()
        {
            PositiveEnumerator positive = new PositiveEnumerator(new int[] { 0, 1, 2, 3, 4, -1 });
            while (positive.MoveNext())
            {
                Console.WriteLine(positive.Current);
            }

            MyEvenEnumerable myEvenEnumerable = new MyEvenEnumerable(new int[] { 1, 2, 3, 4, 5, 6 });
            foreach (var item in myEvenEnumerable)
            {
                Console.WriteLine(item);
            }

            IteratorGenerator var = new IteratorGenerator(10);
            while (var.MoveNext())
            {
                Console.WriteLine(var.Current);
            }
        }
    }
}
