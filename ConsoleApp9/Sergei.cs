using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Sergei : ICollector
    {
        public int Debt { get; set; }
        private int Money { get; set; }


        public Sergei()
        {
            Debt = new Random().Next(10000, 50000);
            Money = new Random().Next(0, Debt);
            Console.WriteLine($"your debt: {Debt}");
            GetManey();
        }
        public Sergei(int debt, int money)
        {
            Debt = debt;
            Money = money;
            GetManey();
        }

        public void GetManey()
        {
            CarJacking();
            Robbery();

        }


        private void CarJacking()
        {
            int rand = new Random().Next(1000, 10000);
            Money += rand;
        }

        private void Robbery()
        {
            int rand = new Random().Next(500, 8000);
            Money += rand;

        }
    }
}
