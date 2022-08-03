using System;
using System.Collections.Generic;
using System.Text;

namespace ArithArea.OOPSDEMO
{
    class Employee
        {
        internal int id;
        internal string name;
        internal int salary;

        public Employee(int id,string name,int salary)
        {
            this.id = id;
            this.name = name;
            this.salary= salary;
        }

        public void Display()
        {
            Console.WriteLine(id + " " + name + " " + salary);
        }
    }
            class ThisUse
            {
        static void Main(string[]args)
        {
            Employee emp = new Employee(1, "Yash", 670000);
            emp.Display();
        }
            }


}
