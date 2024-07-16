using System;
using System.Runtime.CompilerServices;
using System.Security.Principal;

namespace ChildrenBMI
{
    public static class KidsBMi
    {
        private static int age{ get; set; }
        private static string sex{ get; set;}= string.Empty;
        private static double height { get; set; }
        private static double weight { get; set; }
        private static double bmi{ get; set; }
        public static void GetUserInput()
        {
            Console.Write("Enter your age(5-19 yrs old only): ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your sex (M/F): ");
            sex = Console.ReadLine().ToUpper();

            Console.Write("Enter your height in meters: ");
            height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your weight in kilograms: ");
            weight = Convert.ToDouble(Console.ReadLine());
        }

        public static void CalculateBMI()
        {
            bmi = weight / Math.Pow(height, 2);
        }

        public static void DisplayBMI()
        {
            CalculateBMI();
            Console.WriteLine($"Your BMI is: {bmi}");

            double[] bmiPercentiles = GetBMIPercentiles(age, sex);

            if (bmi < bmiPercentiles[0])
            {
                Console.WriteLine("You are Underweight.");
            }
            else if (bmi >= bmiPercentiles[0] && bmi < bmiPercentiles[1])
            {
                Console.WriteLine("You are at Normal weight.");
            }
            else if (bmi >= bmiPercentiles[1] && bmi < bmiPercentiles[2])
            {
                Console.WriteLine("You are Overweight.");
            }
            else
            {
                Console.WriteLine("You are Obese.");
            }
        }

        private static double[] GetBMIPercentiles(int age, string sex)
        {
            double[] percentiles = new double[3];

            if (sex == "M")
            {
                switch (age)
                {
                    case 5:
                        percentiles[0] = 13.0;
                        percentiles[1] = 15.2;
                        percentiles[2] = 16.7;
                        break;
                    case 6:
                        percentiles[0] = 13.0;
                        percentiles[1] = 15.4;
                        percentiles[2] = 16.9;
                        break;
                    case 7:
                        percentiles[0] = 13.2;
                        percentiles[1] = 15.5;
                        percentiles[2] = 17.0;
                        break;
                    case 8:
                        percentiles[0] = 13.4;
                        percentiles[1] = 15.8;
                        percentiles[2] = 17.5;
                        break;
                    case 9:
                        percentiles[0] = 13.5;
                        percentiles[1] = 16.0;
                        percentiles[2] = 17.9;
                        break;
                    case 10:
                        percentiles[0] = 13.8;
                        percentiles[1] = 16.5;
                        percentiles[2] = 18.4;
                        break;
                    case 11:
                        percentiles[0] = 14.0;
                        percentiles[1] = 17.0;
                        percentiles[2] = 19.2;
                        break;
                    case 12:
                        percentiles[0] = 14.5;
                        percentiles[1] = 17.5;
                        percentiles[2] = 20.0;
                        break;
                    case 13:
                        percentiles[0] = 15.0;
                        percentiles[1] = 18.3;
                        percentiles[2] = 20.8;
                        break;
                    case 14:
                        percentiles[0] = 15.5;
                        percentiles[1] = 19.0;
                        percentiles[2] = 21.8;
                        break;
                    case 15:
                        percentiles[0] = 16.0;
                        percentiles[1] = 19.8;
                        percentiles[2] = 22.7;
                        break;
                    case 16:
                        percentiles[0] = 16.5;
                        percentiles[1] = 20.5;
                        percentiles[2] = 23.5;
                        break;
                    case 17:
                        percentiles[0] = 17.0;
                        percentiles[1] = 21.4;
                        percentiles[2] = 24.3;
                        break;
                    case 18:
                        percentiles[0] = 17.3;
                        percentiles[1] = 21.8;
                        percentiles[2] = 25.0;
                        break;
                    case 19:
                        percentiles[0] = 17.5;
                        percentiles[1] = 22.2;
                        percentiles[2] = 25.4;
                        break;
                    default:
                        Console.WriteLine("Age not supported.");
                        break;
                }
            }
            else if (sex == "F")
            {
                switch (age)
                {   
                    case 5:
                        percentiles[0] = 12.7;
                        percentiles[1] = 15.2;
                        percentiles[2] = 18.9;
                        break;
                     case 6:
                        percentiles[0] = 12.7;
                        percentiles[1] = 15.3;
                        percentiles[2] = 19.2;
                        break;
                    case 7:
                        percentiles[0] = 12.7;
                        percentiles[1] = 15.4;
                        percentiles[2] = 19.8;
                        break;
                    case 8:
                        percentiles[0] = 12.9;
                        percentiles[1] = 15.7;
                        percentiles[2] = 20.6;
                        break;
                    case 9:
                        percentiles[0] = 13.1;
                        percentiles[1] = 16.1;
                        percentiles[2] = 21.5;
                        break;
                    case 10:
                        percentiles[0] = 13.5;
                        percentiles[1] = 16.6;
                        percentiles[2] = 22.6;
                        break;
                    case 11:
                        percentiles[0] = 13.9;
                        percentiles[1] = 17.2;
                        percentiles[2] = 23.7;
                        break;
                    case 12:
                        percentiles[0] = 14.4;
                        percentiles[1] = 18.0;
                        percentiles[2] = 25.0;
                        break;
                    case 13:
                        percentiles[0] = 14.9;
                        percentiles[1] = 18.8;
                        percentiles[2] = 26.2;
                        break;
                    case 14:
                        percentiles[0] = 15.4;
                        percentiles[1] = 19.6;
                        percentiles[2] = 27.3;
                        break;
                    case 15:
                        percentiles[0] = 15.9;
                        percentiles[1] = 20.2;
                        percentiles[2] = 28.2;
                        break;
                    case 16:
                        percentiles[0] = 16.2;
                        percentiles[1] = 20.7;
                        percentiles[2] = 28.9;
                        break;
                    case 17:
                        percentiles[0] = 16.4;
                        percentiles[1] = 21.0;
                        percentiles[2] = 29.3;
                        break;
                    case 18:
                        percentiles[0] = 16.4;
                        percentiles[1] = 21.3;
                        percentiles[2] = 29.5;
                        break;
                    case 19:
                        percentiles[0] = 16.5;
                        percentiles[1] = 21.4;
                        percentiles[2] = 29.7;
                        break;
                    
                    default:
                        Console.WriteLine("Age not supported.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid sex.");
            }

            return percentiles;
        }
    }
}
