﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ArithArea.Methoddemo
{
    class Employee
    {

        public int id;
        public string name;
        public double salary;
        public string address;

        public void AcceptDetails(int eid,string ename,double sal,string adr)
        {
            id = eid;
            name = ename;
            salary = sal;
            address = adr;
        }

        public void Display()
        {
            Console.WriteLine(id + " " + name + " " + salary + " " + address);
        }
        static void Main(string[]args)
        {
            Employee e = new Employee();
            e.AcceptDetails(1, "Amit", 780000.899, "Pune");
            e.Display();
        }
    }
}
