﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.Helpers;



namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// 
    ///
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

<<<<<<< Updated upstream
            //DistanceConverter converter = new DistanceConverter();
            //converter.Run();

            BMI calculator = new BMI();
            calculator.Run
            DistanceConverter converter = new DistanceConverter();
            converter.Run();

            BMI converter1 = new BMI();
            converter1.Run();
            
          StudentGrades = new StudentGrades();
            StudentGrades.Run();

        }
    }
}
