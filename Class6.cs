using System;
using System.Collections.Generic;
using System.Text;

namespace Testing
{
    class Incometax
    {
        public Incometax()
        {
           
        }
        public double CalculateTax(int salary)
        {
            int Notaxsalary = 11000;
            int limit1 = 10000;
            int limit2 = 45000;
            int limit3 = 150000;

            if (salary < Notaxsalary) return 0;

            if (salary >= limit1) return (salary - Notaxsalary) * (double)0.45;

            if (salary > limit2) return (salary -Notaxsalary) * (double)0.40;

            if (salary > limit3) return (salary - Notaxsalary) * (double)0.20;


            return 0;
        }
    }
}
