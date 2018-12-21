using ClassWork2;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassWrok2
{
    class Program
    {
        static void Main(string[] args)
        {
            //WorkWithWhere();
            //WorkWithSelect();
            //WorkWithGroupingAndOrderring();
            //ClassWork3();

            string[] str = { "adf", "bbbfff", "1234" };
            var res = str.Aggregate(string.Empty, (acc, el) => acc += el);
            Console.WriteLine(res);

            //var agCount = str.Aggregate(0, (acc, el) => acc += el.Length);
            //Console.WriteLine(agCount);

            //var agMax = str.Aggregate((acc, el) => el.Count() > acc.Count() ? el : acc);
            //Console.WriteLine(agMax);

            //var agMin = str.Aggregate((acc, el) => acc.Count() < el.Count() ? acc : el);
            //Console.WriteLine(agMin);

            //var agAverage = str.Aggregate(0, (acc, el) => (acc + el.Count()) / str.Count());
            //Console.WriteLine(agAverage);

            //int[] ints = { 1, 2, 3, 4, 5, 1 };
            //var result = ints.Join(ints, i => 1, i => 1, (i1, i2) => new KeyValuePair<int, int>(i1, i2)).Where(kvp => kvp.Key != kvp.Value);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Key} - {item.Value}");
            //}




        }


        private static void ClassWork3()
        {
            Book[] books =
            {
                new Book("book", 2014, "John Constantine"),
                new Book("bookLINQ", 2015, "Kobziev Anton"),
                new Book("Order", 2016, "Stifen King"),
                new Book("The BookLINQ", 2016, "John Constantine"),
                new Book("TerminatorLINQ", 2017, "Johny Mnemonyk"),
                new Book("Conan", 2018, "Kiril Nedilko"),
                new Book("BladeLINQ", 2000, "John Constantine")
            };

            var res1 = books.Where(b => b.Name.Contains("LINQ") && DateTime.IsLeapYear(b.Year)).ToList();
            var res2 = new string[] { "fasfas", "fasfsaf", "fdasfas" }.SelectMany(s => s).Distinct().Count();
            var res3 = new int[] { 11, 15, 55, 65, 12, 41 }.OrderBy(i => i / 10).ThenByDescending(i => i % 10);
            var res4 = books.GroupBy(b => b.Author).Select(g => new KeyValuePair<string, IEnumerable<Book>>(g.Key, g));
            foreach (var item in res4)
            {
                Console.WriteLine($"Author: {item.Key}, Number of books: {item.Value.Count()}");
            }
            foreach (var item in Shuffle(new[] { 1, 2, 3, 4, 5, 6 }))
            {
                Console.WriteLine(item);
            }
        }

        private static IEnumerable<T> Shuffle<T>(IEnumerable<T> source)
        {
            Random r = new Random();
            return source.OrderBy(t => r.Next(1000000));
        }

        private static void WorkWithGroupingAndOrderring()
        {
            int[] ints = { 1, 5, 3, 6 };
            string[] input = { "aaaa", "bbb", "aaa" };

            var res = input.OrderByDescending(s => s.Length).ThenBy(s => s);
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }

            var res1 = ints.OrderBy(i => i % 2 == 0).ThenByDescending(i => i);
            foreach (var item in res1)
            {
                Console.WriteLine(item);
            }

            var res3 = input.GroupBy(s => s.Length, s => s.ToUpper()).OrderBy(g => g.Key);

            foreach (IGrouping<int, string> group in res3)
            {
                Console.WriteLine($"String of length {group.Key}");
                foreach (var s in group)
                {
                    Console.WriteLine(s);
                }
            }
        }

        private static void WorkWithSelect()
        {
            var positiveNums = PositiveNumsWithSelect(new int[] { 1, 2, 3, 4, 5, 6, -1, 2, -3, -4 });
        }

        private static IEnumerable<int> PositiveNumsWithSelect(IEnumerable<int> v)
        {
            return v.Select(el => el < 0 ? -el : el);
        }

        private static void WorkWithWhere()
        {
            var postitiveNums = PositiveNums(new int[] { 1, 2, 3, 4, 5, 6, -1, 2, -3, -4 });
            var strWithEnamLength = StrWithEnumLength(new string[] { "dfasf", "fasdfff", "ffdd", "dafasdfadf" });
            var test = PolindromStrings(new string[] { "aaffaa", "adaafa" });
        }

        private static IEnumerable<int> PositiveNums(IEnumerable<int> v)
        {
            return v.Where(el => el > 0);
        }

        private static IEnumerable<string> StrWithEnumLength(IEnumerable<string> v)
        {
            return v.Where(el => el.Length % 2 == 0);
        }

        private static IEnumerable<string> PolindromStrings(IEnumerable<string> v)
        {
            return v.Where(el => el == new string(el.Reverse().ToArray()));            
        }
    }
}
