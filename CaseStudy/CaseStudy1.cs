using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy1
{
    class Student {
        internal int id { get; set; }
        internal string name { get; set; }
        internal DateTime dateofbirth { get; set; }
        internal static string collegeName = "KJSCE";

       public Student(int id, string name, DateTime dateofbirth)
        {
            this.id = id;
            this.name = name;
            this.dateofbirth = dateofbirth;

        }
    }
    
    class Info
    {
        public static void display(Student student)
        {
            Console.WriteLine(student.id + " " + student.name + " " + (student.dateofbirth).ToString("dd/MM/yyyy"));
        }
    }

    class App
    {
        public static void Scenario1()
        {
            Student student1 = new Student(1, "Shraddha", Convert.ToDateTime("14/10/1999"));
            Student student2 = new Student(2, "Rupali", Convert.ToDateTime("21/08/1999"));
            Student student3 = new Student(3, "Shivangi", Convert.ToDateTime("10/02/1999"));

            Info info = new Info();
            Info.display(student1);
            Info.display(student2);
            Info.display(student3);


        }

        public static void Scenario2()
        {
            Student[] students = new Student[3];
            students[0] = new Student(1, "Shraddha", Convert.ToDateTime("14/10/1999"));
            students[1] = new Student(2, "Rupali", Convert.ToDateTime("21/08/1999"));
            students[2] = new Student(3, "Shivangi", Convert.ToDateTime("10/02/1997"));
            foreach(Student su in students)
            {
                Info.display(su);
            }

        }
        public static void Scenario3()
        {
            Console.WriteLine("Enter number of student:");
            int n = Convert.ToInt32(Console.ReadLine());
            Student[] students = new Student[n];
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Enter roll no,name, and dob");
                int id = Convert.ToInt32(Console.ReadLine());
                String name = Console.ReadLine();
                DateTime date = DateTime.Parse(Console.ReadLine());
                students[i] = new Student(id, name, date);


            }
            foreach(Student su in students)
            {
                Info.display(su);
            }
        }

         static void Main()
        {
            App.Scenario1();
            App.Scenario2();
            App.Scenario3();
        }
    }

  
    class CaseStudy1
    {
    }
}
