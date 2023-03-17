using ConsoleAppProject.App02;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Shakthy version 0.1
    /// </author>
    public class BMI
    {
        int weight;
        int height;

        public double Index { get; set; }

        //int BMI = (weight * 703) / (height * height);

        //{ 
        //     private void Input Weight()
        //     private void Input height()
        // }

        public void Run()
        {
            OutputHeading();
            InputHeight();
            InputWeight();
            CalculateBMI();
        }

        private void OutputHeading()
        {
            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("             Calculate the BMI        ");
            Console.WriteLine("                By Shakthy                ");
            Console.WriteLine("----------------------------------------\n");
        }
        private void InputHeight()
        {
            Console.WriteLine("Please enter the height (m):  ");
            string value = Console.ReadLine();
            height = Convert.ToInt32(value);
        }

        private void InputWeight()
        {
            Console.WriteLine("Please enter the weight (kg):  ");
            string value = Console.ReadLine();
            height = Convert.ToInt32(value);
        }
        private void CalculateBMI()
        {
            Index = (weight * 703) / (height * height);

            if (Index < 18.5)
            {
                Console.WriteLine(Index + "\n Underweight" + "\n Please take some multivitamin to get your ideal weight");
            }
            else if (Index > 18.5 && Index < 24.9)
            {
                Console.WriteLine(Index + "\n Normal" + "\n Good and  take your ideal weight");
            }
            else if (Index > 25 && Index < 29.9)
            {
                Console.WriteLine(Index + "\n Overweight" + "\n Please Diet and do some exercise");
            }
            else if (Index > 30)
            {
                Console.WriteLine(Index + "\n Obese" + "\n See a doctor or dietician to have some consultation");
            }
        }

    

        //double weight;
        //int height;
        //double height;
        //int BMI1 = (weight * 703) / (height * height);


        //public void Input Weight();
        //public void Input height();

    }
}
