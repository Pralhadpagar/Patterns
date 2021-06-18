﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
   public class DependecyInjectionExample
    {
        static void Main(string[] args)
        {
            EmployeeBL employeeBL = new EmployeeBL(new EmployeeDAL());
            List<Employee> list = employeeBL.getAllEmployee();
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

        public class EmployeeBL

        {
            // public EmployeeDAL empDal;
            //instead above object weare going to use interface reference variable now. which we will pass into the constructor of this class

            public IEmployeeDAL employeeDAL;

            // created one object which accept dependcy object type.// it can accept any concrete class which implement this interface.
            public EmployeeBL(IEmployeeDAL emp)
            {
                this.employeeDAL = emp;
            }

            public List<Employee> getAllEmployee()
            {
                // dont require object creation here 
                // empDal = new EmployeeDAL();
                return employeeDAL.getEmployeeDetailFromDatabase();

            }
        }
    }
}
