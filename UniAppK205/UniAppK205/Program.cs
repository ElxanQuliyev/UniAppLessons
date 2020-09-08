using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniAppK205
{
    class Program
    {
        static void Main(string[] args)
        {
            K205 k205 = new K205();
            string userInput;
            int input;
            do
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Please select one of the bellow\n");
                Console.WriteLine("1.Add Student");
                Console.WriteLine("2.Show Student and Add Exam");
                Console.WriteLine("3.Add and List Exam ");
                Console.WriteLine("4.Show Exams for Student");
                Console.WriteLine("5.Exit");

                Console.Write(">>>>>>>>");
                userInput = Console.ReadLine();
                if (int.TryParse(userInput, out input))
                {
                    switch (input)
                    {
                        case 1:
                            k205.AddStudent();
                            break;
                        case 2:
                            k205.ShowStudent();
                            break;
                        case 3:
                            k205.AddExam();
                            break;
                        case 4:
                            k205.ShowExamsForStudent();
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.ForegroundColor=ConsoleColor.Red;
                    Console.WriteLine("Warning:Please write numeric number\n");
                }
            } while (userInput != "5");
        }

    }
}
