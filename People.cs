using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Exercises1Sav
{
/// <summary>
/// 
/// </summary>
    class People
    {
        public string Name { get; set; }
        public int Money { get; set; }
        public int AmountMoney { get; set; }

        public People(string name, int money, int AmountMoney)
        {
            this.Name = name;
            this.Money = money;
            this.AmountMoney = money / 4;
        }
    }
}