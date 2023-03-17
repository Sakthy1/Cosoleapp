using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// 
    /// </author>
    /// 
    //sihanharoon@gmail.com
    public class DistanceConverter
    {
        private double miles;
        private double feet;
        public void Run()
        {
            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        private void OutputHeading()
        {
            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("             Convert miles to Feet        ");
            Console.WriteLine("                By Shakthy                ");
            Console.WriteLine("----------------------------------------\n");
        }

        private void InputMiles()
        {
            Console.WriteLine("Please enter the number of miles:  ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        private void CalculateFeet()
        {
            feet = miles * 5280;
        }

        private void OutputFeet()
        {
            Console.WriteLine(miles + "miles is " + feet + "feet!");
        }
    }
}