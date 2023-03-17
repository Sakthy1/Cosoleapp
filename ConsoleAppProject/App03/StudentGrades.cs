using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    public static class EnumExtensions
    {
        public static string GetDescription(this Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var descriptionAttribute = field.GetCustomAttributes(typeof(DescriptionAttribute), false)
                                            .FirstOrDefault() as DescriptionAttribute;

            return descriptionAttribute?.Description ?? value.ToString();
        }
    }

    /// <summary>
    /// At the moment this class just tests the
    /// Grades enumeration names and descriptions
    /// </summary>
    public class StudentGrades
    {
        // Constants (Grade Boundaries)
        public const int LowestMark = 0;
        public const int LowestGradeD = 40;
        public const int LowestGradeC = 50;
        public const int LowestGradeB = 60;
        public const int LowestGradeA = 70;
        public const int HigestMark = 100;

        //properties
        public string[] Student { get; set; }
        public int[] Marks { get; set; }
        public int[] GradeProfile { get; set; }
        public double Mean { get; set; }
        public int Minimum { get; set; }
        public int Maximum { get; set; }
        // Attributes

        public StudentGrades()
        {
            Student = new string[]
                   {
                "Nick","Derek","Quincy",
                "Shakthy","Jaz","Akshith",
                "Jayne","Helen","Milan",
                "Justin","Obama"
                    };
            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[]
            {
                10,20,30,40,50,60,70,80,90,100
            };
        }

        public void Run()
        {
            OutputHeading();
            SelectOptions();
        }
        public void OutputHeading()
        {
            Console.WriteLine("\n---------------------------------------------");
            Console.WriteLine("             Calculate the Student Mark        ");
            Console.WriteLine("                By Shakthy                     ");
            Console.WriteLine("---------------------------------------------\n");
        }
        public void SelectOptions()
        {
            
            string[] choices = new string[]
            {
                "Input Marks",
                "Display Marks",
                "Display Stats",
                "Display Grade Profile",
                "Quit"
            };

            int choice = ConsoleHelper.SelectChoice(choices);

            if (choice == 1)
            {
                InputMarks();
            }
            else if (choice == 2)
            {
                DisplayMarks();
            }
            else if (choice == 3)
            {
                DisplayStats();
            }
            else if (choice == 4)
            {
                DisplayGradeProfile();
            }
            else if (choice == 5)
            {
                Quit();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }

        public void InputMarks()
        {
            OutputHeading();

            for (int i = 0; i < Student.Length && i < Marks.Length; i++)
            {
                int mark;
                bool validInput;

                do
                {
                    Console.Write($"Enter mark for {Student[i]}: ");
                    validInput = int.TryParse(Console.ReadLine(), out mark);

                    if (!validInput)
                    {
                        Console.WriteLine("Error: Please enter a valid integer.");
                    }
                    else if (mark < 0 || mark > 100)
                    {
                        Console.WriteLine("Error: Please enter a mark between 0 and 100.");
                        validInput = false;
                    }
                } while (!validInput);

                Marks[i] = mark;
            }

            Console.WriteLine("\nMarks input complete.");
            Console.WriteLine("Press any key to continue...");

            Console.ReadKey();
            SelectOptions();
        }

        public void DisplayMarks()
        {
            OutputHeading();
            Console.WriteLine();
            Console.WriteLine("+------------+-------+-------------------------+");
            Console.WriteLine("|   Student  | Mark  |        Grade            |");
            Console.WriteLine("+------------+-------+-------------------------+");

            for (int i = 0; i < Student.Length && i < Marks.Length; i++)
            {
                Console.WriteLine($"| {Student[i],-10} | {Marks[i],-5} | {GetGrade(Marks[i]),-23} |");
            }

            Console.WriteLine("+------------+-------+-------------------------+");
            Console.WriteLine();
            Console.WriteLine("\nStudents marks displayed");
            Console.ReadKey();
            Console.WriteLine();
            // Display the options menu
            SelectOptions();
        }

        private string GetGrade(int mark)
        {
            if (mark < 40)
            {
                return Grades.F.GetDescription();
            }
            else if (mark < 50)
            {
                return Grades.D.GetDescription();
            }
            else if (mark < 60)
            {
                return Grades.C.GetDescription();
            }
            else if (mark < 70)
            {
                return Grades.B.GetDescription();
            }
            else if (mark >= 70)
            {
                return Grades.A.GetDescription();
            }
            else
            {
                return Grades.X.GetDescription();
            }
        }
        public Grades ConvertToGrade(int mark)
        {
            if (mark >= 0 && mark < LowestGradeD)
            {
                return Grades.F;
            }
            else if (mark >= LowestGradeD && mark < LowestGradeC)
            {
                return Grades.D;
            }
            else if (mark >= LowestGradeC && mark < LowestGradeB)
            {
                return Grades.C;
            }
            else if (mark >= LowestGradeB && mark < LowestGradeA)
            {
                return Grades.B;

            }
            else if (mark >= LowestGradeA && mark < HigestMark)
            {
                return Grades.A;
            }
            return Grades.F;

        }

        public void DisplayStats()
        {
            OutputHeading();
            Console.WriteLine();
            double total = 0;

            Minimum = HigestMark;
            Maximum = 0;
            foreach (int mark in Marks)
            {
                total = total + mark;
                if (mark > Maximum) Maximum = mark;
                if (mark < Minimum) Minimum = mark;
            }
            Mean = total / Marks.Length;

            Console.WriteLine("Mean: " + Mean.ToString("F2"));
            Console.WriteLine("Minimum: " + Minimum);
            Console.WriteLine("Maximum: " + Maximum);
            Console.WriteLine();
            // Display the options menu
            SelectOptions();
        }

        public void DisplayGradeProfile()
        {
            OutputHeading();
            Console.WriteLine();
            CalculateGradeprofile();
            int[] gradeCounts = new int[5]; // Initialize gradeCounts array with all values set to 0
            foreach (int mark in Marks)
            {
                if (mark >= 90)
                {
                    gradeCounts[4]++;
                }
                else if (mark >= 80)
                {
                    gradeCounts[3]++;
                }
                else if (mark >= 70)
                {
                    gradeCounts[2]++;
                }
                else if (mark >= 60)
                {
                    gradeCounts[1]++;
                }
                else
                {
                    gradeCounts[0]++;
                }
            }

            Console.WriteLine("Grade Profile:");
            int total = Marks.Length;
            Console.WriteLine($"A Grade: {((double)gradeCounts[4] / total) * 100:F2}%");
            Console.WriteLine($"B Grade: {((double)gradeCounts[3] / total) * 100:F2}%");
            Console.WriteLine($"C Grade: {((double)gradeCounts[2] / total) * 100:F2}%");
            Console.WriteLine($"D Grade: {((double)gradeCounts[1] / total) * 100:F2}%");
            Console.WriteLine($"F Grade: {((double)gradeCounts[0] / total) * 100:F2}%");
        }

        public void CalculateGradeprofile()
        {
            for (int i = 0; i < GradeProfile.Length; i++)
            {
                GradeProfile[i] = 0;
            }
            foreach (int mark in Marks)
            {

                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)grade]++;
            }
        }

        public void Quit()
        {
            Environment.Exit(0);
        }
    }
}