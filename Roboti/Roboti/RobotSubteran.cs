using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roboti
{
   public class RobotSubteran : Robot
    {
       public RobotSubteran() { }
       public RobotSubteran(string numeRobot) : base(numeRobot) { }

        public override void Deplasare()
        {
            Console.WriteLine("Sunt robotul subteran {0}" ,Name);
        }
    }
}
