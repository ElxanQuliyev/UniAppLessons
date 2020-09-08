using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniAppK205
{
    class Exam
    {
        public string ExamName { get; set; }
        public string Date { get; set; }
        List<Student> StudentList ;
        public Exam(string ExamName,DateTime Date)
        {
            this.ExamName = ExamName;
            this.Date = Date.ToString("MMMM dd, yyyy");
            StudentList = new List<Student>();
        }
    }
}
