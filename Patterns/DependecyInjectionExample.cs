using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Patterns
{
   public class DependecyInjectionExample
    {
        static void Main(string[] args)
        {
            // Unity allowed u to register certain type of properties which you are going inserting to your other classes.
            // testing database or production ... change then unity is require

            // unity for dependcy injection.

            UnityContainer container = new UnityContainer();
            
            //   container.RegisterType<EmployeeDAL>();
            container.RegisterType<IEmployeeDAL, EmployeeDAL>();
            container.RegisterType<IBusiness, EmployeeBL>();
            EmployeeBL objBL = container.Resolve<EmployeeBL>();
          //  container.RegisterType<EmployeeBL>();
            List<Employee> list = objBL.getAllEmployee();


//            Unity
//StructureMap
//Castle Windsor
//Ninject
//Autofac
//DryIoc
//Simple Injector
//Light Inject



            //this is for constructor injection
            // EmployeeBL employeeBL = new EmployeeBL(new EmployeeDAL());
            // List<Employee> list = employeeBL.getAllEmployee();

            // this is for constuctot injection            
            //EmployeeBL employeeBL = new EmployeeBL();
            //employeeBL.employeeInterfaceprop = new EmployeeDAL();
            //List<Employee> list = employeeBL.getAllEmployee();

            //  this is for method injection
            //// EmployeeBL employeeBL = new EmployeeBL();
            ////List<Employee> list = employeeBL.getAllEmployee(new EmployeeDAL());

            foreach (var item in list)
            {
                Console.WriteLine("ID = {0} , Name ={1}", item.ID, item.name);                           
            }

            Console.ReadKey();

    }

    // 
    // Model
    public class Employee

    {
        public int ID { get; set; }
        public string name { get; set; }

    }
    // Employee Dal is tightly coupled on BL , any change in DAL then change in Employee BL , so lets make do the depency injector who will inject the object for us
    //employee DAL is dependecy object now .. so we are injecting the object of class into class which depends on that object. so employee DAL is dependcy object which is going
    // to use by empoyeed BL.
    public class EmployeeDAL : IEmployeeDAL
    {
        public List<Employee> getEmployeeDetailFromDatabase()
        {
            List<Employee> employeeList = new List<Employee>();

            employeeList.Add(new Employee() { ID = 1, name = "Record1" });
            employeeList.Add(new Employee() { ID = 2, name = "Record2" });

            return employeeList;
        }

    }

    // dependcy object should be interface based
    public interface IEmployeeDAL

    {
        List<Employee> getEmployeeDetailFromDatabase();

    }

    
        public interface IBusiness
        {
            List<Employee> getAllEmployee();
        }
    
    public class EmployeeBL : IBusiness

        {
            // public EmployeeDAL empDal;
            //instead above object weare going to use interface reference variable now. which we will pass into the constructor of this class

            public IEmployeeDAL employeeDAL;

            // created one object which accept dependcy object type.// it can accept any concrete class which implement this interface.

            //constructor injection ; commented or property and method injection. // for unit open it
            public EmployeeBL(IEmployeeDAL emp)
            {
                this.employeeDAL = emp;
            }


            // with property injection

            public IEmployeeDAL employeeInterfaceprop

            {
                set
                {
                    this.employeeDAL = value;    
                }
                get
                {

                    if(employeeInterfaceprop==null)
                    {
                        throw new Exception("employee is not initialized");
                    }
                    else
                    {
                        return this.employeeDAL;
                    }
                }
            }

            //method injection
            //public List<Employee> getAllEmployee(IEmployeeDAL employeedal)
            //{
            //    this.employeeDAL = employeedal;
            //    // dont require object creation here 
            //    // empDal = new EmployeeDAL();
            //    return employeeDAL.getEmployeeDetailFromDatabase();

            //}


            // using unity framework

            public List<Employee> getAllEmployee()
            {                
                return employeeDAL.getEmployeeDetailFromDatabase();

            }
        }
    }
}
