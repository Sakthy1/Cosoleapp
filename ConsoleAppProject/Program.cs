using System;
using ConsoleAppProject.App03;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Derek Peacock 05/02/2022
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    BNU CO453 Applications Programming 2022-2023! ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();
            Console.Beep();

            StudentGrades Stu = new StudentGrades();

            string[] menu = new string[3];
            menu[0] = " Distance Converter";
            menu[1] = " BMI Calculator";
            menu[2] = " Student Grade & Marks";

            int choice = ConsoleHelper.SelectChoice(menu);
            Console.WriteLine();

            if (choice == 1)
            {
                Console.Clear();
                //converter.ConvertDistance();
            }
            else if (choice == 2)
            {
                Console.Clear();
                //calculator.CalculateIndex();
            }
            else if (choice == 3)
            {
                Console.Clear();
                Stu.Run();
            }
            else
            {
                Console.WriteLine(" Invalid Choice !");
            }
        }
    }
}
