﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
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
        public const int highestMark = 100;

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
            Students = new string[]
                   {
                "Nick","Derek","Quincy",
                "Shakthy","Jaz","Akshith",
                "Jayne","Helen","Milan",
                "Justin","Obama"
                    };
            GradeProfile = new int(int)Grades.A + 1];
            Marks = new int[Students.Length];




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

            public void CalculateStats()
            {
                double total = 0;

                Minimum = highestMark;
                Maximum = 0;
                foreach (int mark in Marks)
                {
                    total = total + mark;
                    if (mark > Maximum) Maximum = mark;
                    if (mark < Minimum) Minimum = mark;
                }
                Mean = total / Marks.Length;

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
        }
    }

}