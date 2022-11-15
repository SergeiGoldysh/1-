using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
        public class Shukrat
        {
            public int Debt { get; set; }
            private int Money { get; set; }

        public Shukrat()
        {
            Debt = new Random().Next(10000, 50000);
            Money = new Random().Next(0, Debt);
            Console.WriteLine($"your debt: {Debt}");
            GetMoney();
        }
            public Shukrat(int debt, int money)
            {
                Debt = debt;
                Money = money;
                GetMoney();
            }

            private void GetMoney()
            {
                Theft();
                SellKidney();
            }

            private void Theft()
            {
                int rand = new Random().Next(0, 100);
                Money += rand;

            }
            private void SellKidney()
            {
                int rand = new Random().Next(10000, 100000);
                Money += rand;
            }


        }
}
