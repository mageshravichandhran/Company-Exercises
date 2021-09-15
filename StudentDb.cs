using System;
using System.Collections.Generic;
using System.Text;

namespace Set2
{
    class StudentDb
    {
        string name;
        int age;
        int marks;

        public StudentDb(string name,int age,int marks)
        {

            this.name = name;
            this.age = age;
            this.marks = marks;

        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine("The Name of the Student :{0}", this.name);
            Console.WriteLine("The age of the Student :{0}", this.age);
            Console.WriteLine("The Student obtained {0} marks", this.marks);
        }
        

    }
}
