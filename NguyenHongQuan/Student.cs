using System.Runtime.CompilerServices;

namespace Exam
{
    class Student : IStudent
    {
        public Student()
        {
        }

        public int StudID { get ; set; }
        public string StudName { get; set ; }
        public string StudGender { get; set; }
        public int StudAge { get; set; }
        public string StudClass { get; set; }
        public float StudAvgMark { get;  }

        public void Print()
        {
            Console.WriteLine("Student ID :"+this.StudID);
            Console.WriteLine("Student Name : " +this.StudName);
            Console.WriteLine("Student Gender : " + this.StudGender);
            Console.WriteLine("Student Age : " + this.StudAge);
            Console.WriteLine(" Student Class : " + this.StudClass);
            Console.WriteLine(" Student Avg Mark " + this.StudAvgMark);

        }

        int[] MarkList;
         int[] MarkList = new int[3];
        public MarkList this[int index]
        {

        }

    }
}

