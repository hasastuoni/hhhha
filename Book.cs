using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LI1
{
    class Book
    {
        public Int64 ISBN { get; set; }
        public string BookName { get; set; }
        public string AuthorsName { get; set; }
        public string BookType { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }
        public int Pages { get; set; }
        public Book(Int64 isbn, string bookname, string authorsname, string booktype, string publisher, int year, int pages)
        {
            this.ISBN = isbn;
            this.BookName = bookname;
            this.AuthorsName = authorsname;
            this.BookType = booktype;
            this.Publisher = publisher;
            this.Year = year;
            this.Pages = pages;
        }
    }
}
