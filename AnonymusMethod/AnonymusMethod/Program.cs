using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymusMethod
{
    class Program
    {
       

        static void Main(string[] args)
        {
            List<Employee> listofEmployees = new List<Employee>(){
               new Employee(){Name = "Alin",Age=20,Occupation = "Engineer"},
               new Employee(){Name = "Alexandru",Age = 34,Occupation = "Programmer"},
               new Employee(){Name = "Ion",Age=29,Occupation = "Tester"},
               new Employee(){Name = "Iancu",Age=37,Occupation = "Tester"},
               new Employee(){Name = "Marian",Age=25,Occupation = "WebDeveloper"},
           };


            List<Employee> employeeUnderThirty = listofEmployees.FindAll(delegate(Employee e) { return e.Age < 30; });
            foreach (Employee e in employeeUnderThirty)
            {
                Console.WriteLine("{0} are sub 30 de ani", e.Name);
            }

            // Selectare persoane care au job-ul tester

            List<Employee> testerEmployees = listofEmployees.FindAll(delegate(Employee e) { return e.Occupation == "Tester"; });

            foreach(Employee emp in testerEmployees){
                Console.WriteLine("Tester : {0}",emp.Name);
            }
        }
    }
}
