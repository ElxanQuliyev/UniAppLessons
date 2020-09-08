using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UniAppK205
{
    class K205
    {
       public List<Student> StudentList;
       public List<Exam> Exams;

        public K205()
        {
            StudentList = new List<Student>();
            Exams = new List<Exam>();
            Exam html = new Exam("Html",new DateTime(2020,05,06));
            Exam css = new Exam("Css", new DateTime(2020, 09, 03));
            Exam js = new Exam("Javascript", new DateTime(2020, 02, 01));
            Exams.Add(html);
            Exams.Add(css);
            Exams.Add(js);

        }
        public void AddStudent()
        {
            Console.WriteLine("\n*********************");
            Console.Write("Please write student's name:");
            string name=Console.ReadLine();
            if (name.Length > 2)
            {
                Student stu = new Student(name);
                StudentList.Add(stu);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nStudent was addded successfully");
            }
        }

        public void ShowStudent()
        {
            if (StudentList.Count>0)
            {
                Student selectedStudent = null;
                foreach (Student stu in StudentList)
                {
                    Console.WriteLine("Id:{0},Name:{1}", stu.Id, stu.Fullname);
                }
            Start:
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Please,Select student's by Id: ");
                string stuId = Console.ReadLine();
                int id;
                if (int.TryParse(stuId, out id))
                {
                    bool correctId = false;
                    foreach (Student stu in StudentList)
                    {
                        if (stu.Id == id)
                        {
                            correctId = true;
                            selectedStudent = stu;
                            break;
                        }
                    }
                    if (correctId)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Your ,Selected Student's name:{0}\n", selectedStudent.Fullname);
                        ShowExams(selectedStudent);
                    }

                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nWarning:Please,select a valid id...");
                        goto Start;
                    }

                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nWaring: Please,don't input a word");
                    goto Start;
                }
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nWaring: Student not found");
            }

        }
        public void ShowExams(Student selectedStu)
        {
            Exam SelectedExam = null;
            foreach (Exam ex in Exams)
            {
                Console.WriteLine("Exam Name:{0},Exam Date:{1}", ex.ExamName,ex.Date);
            }
        Start:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Please,Select Exam's by Name: ");
            string examName = Console.ReadLine();

            bool correctName = false;
                foreach (Exam ex in Exams)
                {
                    if (ex.ExamName == examName)
                    {
                        correctName = true;
                        SelectedExam = ex;
                        break;
                    }
                }
                if (correctName)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Exam's name:{0} was added to Student's name:{1}\n", SelectedExam.ExamName,selectedStu.Fullname);
                selectedStu.ExamList.Add(SelectedExam);    
            }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nWarning:Please,select a valid exam name...");
                    goto Start;
                }

            }

        public void AddExam()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("_________***_________");
            Console.Write("Please,write exam name: ");

            string exname = Console.ReadLine();
            if (!string.IsNullOrEmpty(exname))
            {
                Exam exm = new Exam(exname,DateTime.Now);
                Exams.Add(exm);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("_________***_________");
                Console.WriteLine("Success,Exam Name was added successfully");
                foreach (var ex in Exams)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;

                    Console.WriteLine("Exam Name:{0},Exam Date:{1}", ex.ExamName, ex.Date);
                }
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("_________***_________");
                Console.Write("Please,fiel exam name: ");
            }
        }

        public void ShowExamsForStudent()
        {
            Exam SelectedExam = null;
            foreach (Exam ex in Exams)
            {
                Console.WriteLine("Exam Name:{0},Exam Date:{1}", ex.ExamName, ex.Date);
            }
        Start:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Please,Select Exam's by Name: ");
            string examName = Console.ReadLine();

            bool correctName = false;
            foreach (Exam ex in Exams)
            {
                if (ex.ExamName == examName)
                {
                    correctName = true;
                    SelectedExam = ex;
                    break;
                }
            }
            if (correctName)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Student Name For Exam's name:{0}\n",SelectedExam.ExamName);
                foreach (Student stu in StudentList)
                {
                    if (stu.ExamList.Count ==0) {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nWarning:Selected Student was not found any Exam...");
                        break;
                    }
                    else if(stu.ExamList.Contains(SelectedExam))
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Student id:{0} , Student name:{1}",stu.Id,stu.Fullname);
                    } 
                }
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nWarning:Please,select a valid exam name...");
                goto Start;
            }

        }
    }
    }
