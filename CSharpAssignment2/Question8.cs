using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment2
{
   public class student1
    {
        public int RollNo;
        public string StudName;
        public int MarksInEng;
        public int MarksInMaths;
        public int MarksInScience;
        public void TotalMarks()
        {
            int tot = MarksInEng + MarksInMaths + MarksInScience;
            Console.WriteLine("Total Marks:{0}", tot);
        }
        public void AvgMarks()
        {
            int avg = (MarksInEng + MarksInMaths + MarksInScience)/3;
            Console.WriteLine("Average Marks:{0}", avg);
        }

    }
    class Question8
    {
        public static void Main()
        {
            student1 s1 = new student1();
            s1.RollNo = 45;
            s1.StudName = "Rohan";
            s1.MarksInEng = 45;
            s1.MarksInMaths = 55;
            s1.MarksInScience = 48;
            s1.TotalMarks();
            s1.AvgMarks();

        }
        
    }
}
