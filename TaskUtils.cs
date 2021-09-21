using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LI1
{
    class TaskUtils
    {
        public static List<string> FindAuthors(List<Book> books)
        {
            List<string> Authors = new List<string>();
            foreach(Book book in books)
            {
                string author = book.AuthorsName;
                if (!Authors.Equals(author))
                {
                    Authors.Add(author);
                }
            }
            return Authors;
        }
        /// <summary>
        /// Find amount of books which are older than 2 years
        /// </summary>
        /// <param name="books"></param>
        /// <returns>amount of books</returns>
        public static  int Counter(List<Book> books)
        {
            int count = 0;
            foreach(Book book in books)
            {
                int yeardif = 0;
                yeardif = 2021 - book.Year;
                if(yeardif >= 2)
                {
                    count++;
                }
            }
            return count;
        }
        public static List<string> FindPublishers(List<Book> books)
        {
            List<string> Publishers = new List<string>();
            foreach (Book book in books)
            {
                string publishers = book.Publisher;
                if(!Publishers.Contains(publishers))
                {
                    Publishers.Add(publishers);
                }
            }
            return Publishers;
        }
    }
}
