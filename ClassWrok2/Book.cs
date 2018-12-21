using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork2
{
    public class Book
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public string Author { get; set; }

        public Book(string name, int year, string author)
        {
            Name = name;
            Year = year;
            Author = author;
        }
    }
}
