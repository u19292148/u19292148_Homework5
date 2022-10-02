using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19292148_Homework5.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public String BookName { get; set; }
        public int PageCount { get; set; }
        public int Point { get; set; }

        public Author Author { get; set; }
        public Type Type { get; set; }

        public Book()
        {
            Author = new Author();
            Type = new Type();
        }
    }
}