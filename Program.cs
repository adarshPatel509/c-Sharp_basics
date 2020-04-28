using System;
using System.Collections.Generic;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            //variables & constants
            Variables myVar = new Variables();
            myVar.details();

            Constants myConst = new Constants();
            myConst.actions(10);
            myConst.actions(25);

            //inheritance, polymorphsim & encapsulation
            Employee adarsh = new Manager("Adarsh", true);
            Employee arpit = new Worker("Arpit", 25.5); 
            Employee ankur = new Worker("Ankur", 50.50);
            List<Employee> employees = new List<Employee>() {
                adarsh, arpit, ankur
            };

            for(int i=0; i<employees.Count; i++) {
                employees[i].TakeVacation();
                Console.WriteLine(employees[i].ToString());
            }

            //exception handeling
            ExceptionDemo someExc = new ExceptionDemo();

            //collections: array, list & dictionary
            Arrays grades = new Arrays();
            Lists familyMembers = new Lists();
            Dict myDict = new Dict();

            //interfaces
            DemoInterfaces myInterfaces = new DemoInterfaces();

            //abstract classes
            AbsDemo absClass = new AbsDemo();

            //NullOperators
            NullOperators nullOper = new NullOperators();

            //events & delegates
            EventDemo newEvent = new EventDemo();
        }
    }
}
