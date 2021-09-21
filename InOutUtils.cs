using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Exercises1Sav
{
    /// <summary>
    /// Opens and sends information to all program, outputs the information
    /// </summary>
    static class InOutUtils
    {
        public static int AmountMoney { get; private set; }

        public static List<People> ReadPeople(string fileName)
        {
            List<People> Peoples = new List<People>();
            string[] Lines = File.ReadAllLines(fileName, Encoding.UTF8);
            foreach (string line in Lines)
            {
                string[] Values = line.Split(';');
                string name = Values[0];
                int money = int.Parse(Values[1]);

                People people = new People(name, money,AmountMoney);
                Peoples.Add(people);
            }

            return Peoples;
        }
        public static void PrintPeople(List<People> Peoples)
        {
            Console.WriteLine(new string('-', 74));
            Console.WriteLine("| {0,-15} | {1,-25} |",
                "Vardas", "Pinigu suma");
            Console.WriteLine(new string('-', 74));
            foreach (People people in Peoples)
            {
                Console.WriteLine("| {0,-15} | {1,-25} |",
                    people.Name, people.Money);
            }
            Console.WriteLine(new string('-', 74));
        }
        public static void PrintPeopleToCSVFile(string fileName, List<People> Peoples)
        {
            string[] lines = new string[Peoples.Count + 1];
            lines[0] = String.Format("{0};{1}",
                "Vardas", "Pinigai");
            for (int i = 0; i < Peoples.Count; i++)
            {
                lines[i + 1] = String.Format("{0};{1}",
                    Peoples[i].Name, Peoples[i].Money);
            }
            File.WriteAllLines(fileName, lines, Encoding.UTF8);
        }
    }
}