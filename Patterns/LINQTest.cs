using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
   public class LINQTest
    {
        public static void Main()
        {

            List<Employee> listEmployees = new List<Employee>()
            {
                //new Employee{ ID = 101, Name = "Pranaya", Gender = "Male", Salary = 100000,Age =25 },
                //new Employee{ ID = 102, Name = "Priyanka", Gender = "Female", Salary = 200000,Age =25},
                //new Employee{ ID = 103, Name = "Anurag", Gender = "Male", Salary = 300000,Age =25},
                //new Employee{ ID = 104, Name = "Preety", Gender = "Female", Salary = 400000,Age =25},
                //new Employee{ ID = 104, Name = "Sambit", Gender = "Male", Salary = 500000,Age =21},
                new Employee{ ID = 101, Name = "Pranaya", Gender = "Male", Salary = 10,Age =25 },
                new Employee{ ID = 101, Name = "Priyanka", Gender = "Female", Salary = 200000,Age =25},
                new Employee{ ID = 101, Name = "Anurag", Gender = "Male", Salary = 300000,Age =25},
                new Employee{ ID = 104, Name = "Preety", Gender = "Female", Salary = 400000,Age =25},
                new Employee{ ID = 104, Name = "Sambit", Gender = "Male", Salary = 500000,Age =21},
            };

            List<Employee> listCutomer = new List<Employee>()
            {
                //new Employee{ ID = 101, Name = "Pranaya", Gender = "Male", Salary = 100000,Age =25 },
                //new Employee{ ID = 102, Name = "Priyanka", Gender = "Female", Salary = 200000,Age =25},
                //new Employee{ ID = 103, Name = "Anurag", Gender = "Male", Salary = 300000,Age =25},
                //new Employee{ ID = 104, Name = "Preety", Gender = "Female", Salary = 400000,Age =25},
                //new Employee{ ID = 104, Name = "Sambit", Gender = "Male", Salary = 500000,Age =21},
                new Employee{ ID = 101, Name = "Pranaya", Gender = "Male", Salary = 10,Age =25 },
                new Employee{ ID = 101, Name = "Priyanka", Gender = "Female", Salary = 200000,Age =25},
                new Employee{ ID = 101, Name = "Anurag", Gender = "Male", Salary = 300000,Age =25},
                new Employee{ ID = 104, Name = "Preety", Gender = "Female", Salary = 400000,Age =25},
                new Employee{ ID = 104, Name = "Sambit", Gender = "Male", Salary = 500000,Age =21},
            };

            //  IList<int> intList = new List<int>() { 1, 2, 3, 4, 5 };
            // bool result = intList.Contains(10);  // returns false
            // checks whether all the students are teenagers    
            //bool areAllStudentsTeenAger = listEmployees.All(s => s.Age > 12 && s.Age < 20);

            //var emp = listEmployees.FirstOrDefault(x => x.ID == 101);
            //bool areAllStudentsTeenAger = listEmployees.Any(s => s.Age > 12 && s.Age < 20);
            // bool result = listEmployees.Contains(listEmployees.FirstOrDefault(x=>x.Name=="Pranaya"));

            // var record = listEmployees.FirstOrDefault(x => x.ID==11);

            //var skiprecords = listEmployees.TakeWhile(x => x.Gender == "Male");
            //////IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
            //////IList<string> strList = new List<string>() { null, "Two", "Three", "Four", "Five" };
            //////IList<string> emptyList = new List<string>();

            //////Console.WriteLine("1st Element in intList: {0}", intList.First());
            //  bool result = listEmployees.Contains(emp.ID);

            // Console.WriteLine(result);

            var obj = from p in listEmployees
                      where p.ID == 101
                      let name = p.Name.ToLower()
                      let salary = p.Salary
                      where name.StartsWith("p") && salary > 100
                      select new
                      {
                          name,
                          salary

                      };

            // into

            var temp = from p in listEmployees
                       where p.ID == 101
                       select p
                           into temp1
                       where temp1.Name.StartsWith("P")
                       select temp1.Name;

            // join two list

            var collect = from p in listEmployees
                          join cc in listCutomer
                          on p.ID equals cc.ID                         
                        //  into te
                          where p.ID == 100
                          select new
                          {
                              p.ID,
                              p.Name
                          };


        Console.ReadKey();
        }

    }

    public class classcompare : IEqualityComparer<employee>
    {
        //public bool Equals(T x, T y)
        //{
        //    x.values
        //    //throw new NotImplementedException();
        //}

        public bool Equals(employee x, employee y)
        {
            throw new NotImplementedException();
        }

        //public int GetHashCode(T obj)
        //{
        //    throw new NotImplementedException();
        //}

        public int GetHashCode(employee obj)
        {
            throw new NotImplementedException();
        }
    }
}
