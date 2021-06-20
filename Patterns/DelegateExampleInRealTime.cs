using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Patterns.employee;

namespace Patterns
{

    public class DelegateExampleInRealTime
    {

        public static void Main()
        {

            employee emp1 = new employee

            {
                Name = "Raaa",
                Salary = 522

            };
            employee emp2 = new employee

            {
                Name = "PPP",
                Salary = 99

            };

            List<employee> emp = new List<employee>();
            emp.Add(emp1);
            emp.Add(emp2);
            IsPromote pro = new IsPromote(Promote);
            employee.promotedEmployee(emp, pro);
            Console.ReadKey();
             bool Promote(employee emp8)
            {
                if(emp8.Salary>100)
                {
                    return true;

                }
                else
                {

                    return false;
                }


            }

            
        }

    }

    public class employee
    {

        public string Name { get; set; }
        public int Salary { get; set; }

        public delegate bool IsPromote(employee emp);
        public static void promotedEmployee(List<employee> emp , IsPromote promote)
        {

            foreach (var item in emp)
            {
                if(promote(item))
                {
                    Console.WriteLine("Promoted {0}", item.Name);
                }
                //if (item.Salary > 100)
                //{
                //    
                //}
               
            }
            
        }


    }
}
