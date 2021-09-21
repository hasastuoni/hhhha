using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Exercises1Sav
{

    class Program
    {
        static void Main(string[] args)
        {
            List<People> allPeople = InOutUtils.ReadPeople(@"Islaidos.csv");
            InOutUtils.PrintPeople(allPeople);
            int cash = TaskUtils.CountMoney(allPeople);
            Console.WriteLine("Pinigai : {0}", cash);
            People most = TaskUtils.MostMoney(allPeople);
            Console.WriteLine("Daugiausiai dave: {0} {1}", most.Name, most.AmountMoney);

        }
    }
}