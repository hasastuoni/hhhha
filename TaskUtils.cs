using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Exercises1Sav
{
    static class TaskUtils
    {
    /// <summary>
    /// Find total amount of money
    /// </summary>
    /// <param name="peoples"></param>
    /// <returns>Total amount of money</returns>
        public static int CountMoney(List<People> peoples)
        {
            int count = 0;
            int total = 0;
            foreach (People people in peoples)
            {
                count = people.Money / 4;
                total = total + count;
            }
            return total;
        }
        /// <summary>
        /// Find a person which gave the most money from the split
        /// </summary>
        /// <param name="peoples"></param>
        /// <returns>A person...</returns>
        public static People MostMoney(List<People> peoples)
        {
            People most = peoples[0];
            List<People> people = new List<People>();
            for (int i = 0; i < peoples.Count; i++)
            {
                if (peoples[i].AmountMoney >= most.AmountMoney)
                {
                    most = peoples[i];
                }
            }
            return most;
        }
    }
    }