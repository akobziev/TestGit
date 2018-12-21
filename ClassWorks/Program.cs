using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWorks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //foreach (var item in TaskOne(new Products().ProductList))
            //{
            //    Console.WriteLine(item.Name);
            //}

            Console.WriteLine("aaaaaaddd".WithoutVowels());
        }

        private static Dictionary<int, List<Product>> TaskTwo(IEnumerable<Product> productList)
        {
            var dict = new Dictionary<int, List<Product>>();
            foreach (var item in productList)
            {
                int range = (int)item.Price / 10;
                if (!dict.ContainsKey(range))
                {
                    dict[range] = new List<Product>();
                }
                dict[range].Add(item);
            }
            return dict;
        }

        private static List<Product> TaskOne(IEnumerable<Product> products)
        {
            var res = new List<Product>();
            foreach (var item in products)
            {
                if (item.Price < 25)
                {
                    res.Add(item);
                }
            }
            return res;
        }
    }

    public static class MyExtensions
    {
        public static string WithoutVowels(this string obj)
        {
            var vowels = new HashSet<char>("aeiouy");
            var res = new StringBuilder();
            foreach (var item in obj)
            {
                if (!vowels.Contains(item))
                {
                    res.Append(item);
                }
            }
            return res.ToString();
        }
    }
}
