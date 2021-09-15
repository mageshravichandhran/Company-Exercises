using System;
using System.Collections.Generic;
using System.Text;
//4.	Define a class Employee with attributes – name, salary. Calculate – Gross salary, net salary. Assume DA-20%; HRA-15%, PF-12%. 
namespace Set2
{
    class EmployeeDb



    {
        static double DA = 0.2;
        static double HRA = 0.15;
        static double PF = 0.12;
        string name;
        double salary;

        public EmployeeDb(string name,int salary)
        {
            this.name = name;
            this.salary = salary;

        }

        public double CalcGrossSalary()
        {


            return  this.salary * DA + salary;



        }


        public double CalcNetSalary()
        {
            return CalcGrossSalary() - this.salary * HRA + this.salary * PF;
        }
    }
}
