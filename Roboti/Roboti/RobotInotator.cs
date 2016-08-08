using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roboti
{
    public class RobotInotator : Robot
    {
      public RobotInotator() { }
      public RobotInotator(string numeRobot) : base(numeRobot) { }

        public override void Deplasare()
        {
            Console.WriteLine("Sunt robotul inotator {0}" ,Name);
        }


    }
}
