using System;
using System.Collections.Generic;
using System.Linq;

namespace IsPolindrom
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(IsPolindrom(120021));          
            
        }

        private static int MinimalIntegerNotIn(int[] v)
        {
            throw new NotImplementedException();
        }

        private static bool HasDuplicates(string s)
        {
            var counter = 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        counter++;
                    }
                }
            }
            return counter > 0;
        }

        private static bool IsPolindrom(int a)
        {
            string str = a.ToString();
            IEnumerable<char> revChars = str.Reverse();
            string rev = string.Empty;
            foreach (var c in revChars)
            {
                rev += c;
            }

            return rev == str;
        }

        
    }
}
