using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LI1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> allBook = InOutUtils.ReadBooks(@"Sarasas.csv");
            InOutUtils.PrintBooks(allBook);
            List<string> Publisher = TaskUtils.FindPublishers(allBook);
            Console.WriteLine("Autorius:");
            InOutUtils.PrintPublisher(Publisher);
            Console.WriteLine();
            int count = TaskUtils.Counter(allBook);
            Console.WriteLine("Senesnes knygos negu 2 metai:{0}", count);
            List<string> Authors = TaskUtils.FindAuthors(allBook);
            InOutUtils.PrintAuthor(Authors);
            Console.WriteLine();
 
        }
    }
}
