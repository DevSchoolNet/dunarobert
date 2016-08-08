using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roboti
{
    public abstract class Robot
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }

        public Robot() { }
        public Robot(string numeRobot)
        {
            Name = numeRobot;
        }

        public virtual void Deplasare()
        {
            Console.WriteLine("Clasa parinte robot");
        }

        public virtual void InhataObiect()
        {
            Console.WriteLine("Sunt robotul {0} am inhatat {1} si sunt gata de munca ", Name);
        }

        public virtual void Actiune()
        {
            Console.WriteLine("Sunt robotul {0} si ma duc la munca", Name);
        }

    }

    



}
