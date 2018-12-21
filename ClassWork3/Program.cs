using System;
using System.Collections;
using System.Linq;

namespace ClassWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList
            {
                123,
                "str",
                new object(),
                new int[10]
            };
            var res = list.OfType<int>();
            Console.WriteLine(res.Count());

            var str = "abc bc defg def";
            //var resDict = str.Split().ToDictionary(s => s.Length);
            var resToLookup = str.Split().ToLookup(s => s.Length);




        }
    }
}
