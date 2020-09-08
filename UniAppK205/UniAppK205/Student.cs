using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniAppK205
{
    class Student
    {
        public  string Fullname { get; set; }
        public int Id { get;private set; }
        public List<Exam> ExamList{ get; set; }
        private static int stuId = 1; 

        public Student(string Fullname)
        {
            this.Fullname = Fullname;
            Id =stuId;
            stuId++;
            ExamList = new List<Exam>();
        }
    }
}
