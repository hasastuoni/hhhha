using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LI1
{
    static class InOutUtils
    {
        public static List<Book> ReadBooks(string fileName)
        {
            List<Book> Books = new List<Book>();
            string[] Lines = File.ReadAllLines(fileName, Encoding.UTF32);
            foreach (string line in Lines)
            {
                string[] Values = line.Split(';');
                Int64 isbn = Int64.Parse(Values[0]);
                string bookname = Values[1];
                string authorsname = Values[2];
                string booktype = Values[3];
                string publisher = Values[4];
                int year = int.Parse(Values[5]);
                int pages = int.Parse(Values[6]);

                Book book = new Book(isbn, bookname, authorsname, booktype,publisher, year, pages);
                Books.Add(book);
            }
            return Books;
        }
        public static void PrintBooks(List<Book> Books)
        {
            Console.WriteLine(new string('-', 115));
            Console.WriteLine("| {0,-13} | {1,-20} | {2,-20} | {3,-10} | {4,-10} | {5,-5} | {6,-5} |",
                "ISBN", "Knygos pavadinimas", "Autorius", "Tipas","Leidykla", "Metai", "Puslapių kiekis");
            Console.WriteLine(new string('-', 115));
            foreach(Book book in Books)
            {
                Console.WriteLine("| {0,-10} | {1,-20} | {2,-20} | {3,-10} | {4,-10} | {5,-5} | {6,-15} |",
                    book.ISBN, book.BookName, book.AuthorsName, book.BookType,book.Publisher, book.Year, book.Pages);
            }
            Console.WriteLine(new string('-', 115));
        }
        public static void PrintPublisher(List<string> publisher)
        {
            foreach (string publishers in publisher)
            {
                Console.WriteLine(publishers);
            }
        }
        public static void PrintAuthor(List<string> authors)
        {
            foreach (string author in authors)
            {
                Console.WriteLine(author);
            }
        }
    }
}
