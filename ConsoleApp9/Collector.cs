using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Collector
    {
        public double Rage { get; set; }

        public const double Cap = 5000;

        public void BreakKnee(Shukrat shukrat, Sergei sergei)
        {
            if(shukrat.Debt > Cap)
            {
                Console.WriteLine("The debt is too big, we will break your knees!");
            }
            else
            {
                Console.WriteLine("Be careful on our counter...");
            }

            if (sergei.Debt > Cap)
            {
                Console.WriteLine("The debt is too big, we will break your knees!");
            }
            else
            {
                Console.WriteLine("Be careful on our counter...");
            }

        }
    }
}
