using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roboti
{
    public class RobotZburator : Robot
    {
        private readonly string arma = "sabia";
        public  string Arma
        {
            get
            {
                return arma;
            }
        }
        public RobotZburator() { }
        public RobotZburator(string numeRobot) : base(numeRobot) { }

        public override void Deplasare()
        {
            Console.WriteLine("Sunt robotul zburator {0} si stiu sa lupt" ,Name);
        }

        public override void InhataObiect()
        {
            Console.WriteLine("Sunt robotul {0} am inhatat {1} si sunt gata sa lupt ", Name, Arma);
        }

        public override void Actiune()
        {
            Console.WriteLine("Sunt robotul {0} si ma duc la lupta", Name);
        }
    }
}
