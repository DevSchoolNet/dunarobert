using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roboti
{
    class RobotTerestru : Robot
    {
        private readonly string unealta = "sapa";
        public string Unealta
        {
            get
            {
                return unealta;
            }
        }

        public RobotTerestru() { }
        public RobotTerestru(string numeRobot) : base(numeRobot) { }

        public override void Deplasare()
        {
            Console.WriteLine("Sunt robotul terestru {0} si muncesc cu sapa",Name);
        }

        public override void InhataObiect()
        {
            Console.WriteLine("Sunt robotul {0} am inhatat {1} si sunt gata de munca ", Name, Unealta);
        }

        public override void Actiune()
        {
            Console.WriteLine("Sunt robotul {0} si ma duc la munca", Name);
        }
    }
}
