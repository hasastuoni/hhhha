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

            // Print all authors.
            List<string> Authors = TaskUtils.FindAuthors(allBook);
            //InOutUtils.PrintAuthor(Authors);

            // Dictionary <string (author), int (repeated count)
            Dictionary<string, int> AuthorCount = new Dictionary<string, int>();

            for(int i = 0; i < Authors.Count; i++)
            {
                if(!AuthorCount.ContainsKey(Authors[i]))
                {
                    AuthorCount.Add(Authors[i], 1);
                } else
                {
                    AuthorCount[Authors[i]] += 1;
                }
            }

            int max = 0;
            string authorMax = "";

            foreach (KeyValuePair<string, int> kvp in AuthorCount)
            {
                if (Int32.Parse(kvp.Value.ToString()) > max)
                {
                    max = kvp.Value;
                    authorMax = kvp.Key;
                }
            }

            Console.WriteLine("Top Author: {0}", authorMax);

            Console.WriteLine();

            
            while(true) { }
        }
    }
}
