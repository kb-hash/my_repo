using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment2
{
    class Student
    {
        public int rollNo;
        public string name;
        public string cls;
        public string sem;
        public string branch;
        public int[] marks = new int[5];
        public double average;
        public Student()
        {
            Console.Write("Enter Roll No:");
            rollNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name:");
            name = Convert.ToString(Console.ReadLine());
            Console.Write("Enter Class:");
            cls = Convert.ToString(Console.ReadLine());
            Console.Write("Enter Semester:");
            sem = Convert.ToString(Console.ReadLine());
            Console.Write("Enter Branch:");
            branch = Convert.ToString(Console.ReadLine());
            for(int i=0;i<5;i++)
            {
                Console.Write("Enter subject {0} Mark:", i+1);
                marks[i] = int.Parse(Console.ReadLine());
            }

        }
        public void DisplayData()
        {
            Console.WriteLine("Roll NO:{0}  Name:{1}  Class:{2}  Semester:{3}  Branch:{4}  Average Marks:{5}", rollNo,name,cls,sem,branch,average);
        }

        public void DisplayResults()
        {
            average = marks.Average();
            if (average < 50)
            {
                Console.WriteLine("FAIL");
            }

            foreach (int k in marks)
                if (k < 35)
                {
                    Console.WriteLine("FAIL");
                }
            foreach (int k in marks)
                if (k > 35 && average>50)
                {
                    Console.WriteLine("PASS");
                }




        }
    }
    class Question3
    {
        static void Main()
        {
            Student s1 = new Student();
            s1.DisplayResults();
            s1.DisplayData();
        }
    }
}
