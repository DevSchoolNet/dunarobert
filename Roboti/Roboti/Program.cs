using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roboti
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Din momentul acesta esti stapanul turmei de roboti");
            Console.WriteLine("Pentru ca robotii sa se deplaseze trebuie sa tastezi Valea");
            Console.WriteLine("Pentru ca robotii sa manuiasca obiecte trebuie sa tastezi Pregatiti-va");
            Console.WriteLine("Pentru ca robotii sa munceasca trebuie sa tastezi Munciti");
           List<Robot> roboti = new List<Robot>()
            {
                 new RobotZburator{Name = "RZ_2372"},
                new RobotZburator{Name = "RZ_9201"},
                new RobotZburator{Name = "RZ_2837"},
                new RobotZburator{Name = "RZ_8721"},
                new RobotTerestru {Name="RT_7122"},
                new RobotTerestru{Name = "RT_8817"},
                new RobotTerestru{Name = "RT_1596"},
                new RobotTerestru{Name = "RT_6124"},
                new RobotTerestru{Name = "RT_8821"},
                  new RobotInotator{Name = "RI_1761"},
                new RobotInotator{Name = "RI_9812"},
                new RobotSubteran{Name = "RS_8121"}
            };
            


            Console.WriteLine("Doriti sa continuati DA sau NU");
            
            do
            {
                while (Console.ReadLine().ToUpper() != "DA" && Console.ReadLine().ToUpper() != "NU")
                {
                    string x = Console.ReadLine().ToUpper();
                    if (x != "DA" && x != "NU")
                    {
                        Console.WriteLine("Alegere gresita! Trebuie sa scrieti DA sau NU");
                    }
                } 
                
                

                Console.WriteLine("acum alegeti una din comenzile VALEA, PREGATIITI-VA sau MUNCITI");
                string alegere = Console.ReadLine().ToUpper();
                if (alegere == "VALEA")
                {
                    foreach (var rZ in roboti)
                    {
                        rZ.Deplasare();
                    }
                }
                else
                {
                    if (alegere == "PREGATITI-VA")
                    {
                        foreach (Robot s in roboti)
                        {
                            if (s is RobotTerestru || s is RobotZburator)
                                s.InhataObiect();
                        }
                    }
                    else
                    {
                        if (alegere == "MUNCITI")
                        {
                            foreach (var i in roboti)
                            {
                                if (i is RobotTerestru || i is RobotZburator)
                                    i.Actiune();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Doriti sa continuati ? Da sau Nu");
                        }
                    }
                }


            }
            while (Console.ReadLine().ToUpper() == "DA");
        }

       
    }
}
