// https://regexr.com/

using System;
using System.Text.RegularExpressions;

namespace RegExpresions
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] values = { "000-111-22-33", "00-111-22-33" };
            string text = "000-111-22-33";
            string pattern = @"^\d{3}-\d{3}-\d{2}-\d{2}$";

            foreach (var value in values)
            {
                if (Regex.IsMatch(value, pattern))
                {
                    var matched = Regex.Match(value, pattern);
                    string str = matched.Value;
                    Console.WriteLine(str);
                }
            }

            //var matched = Regex.Matches(text, pattern);

        }
    }
}
