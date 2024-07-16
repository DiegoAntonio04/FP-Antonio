using System.Xml.XPath;
using ChooseDiet;

namespace BMIADULT
{
    public class GrownUPBMI 
    {
        public static void OldBMICalc()
        {   
            double height, weight, range;
            Console.WriteLine("Enter your height and weight: ");
            Console.WriteLine("---------------------------------------");
            Console.Write("Height(in Meters): ");
            height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Weight(in Kilograms): ");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("---------------------------------------");
            range = weight / Math.Pow(height, 2);
            Console.WriteLine($"Your BMI is: {range}");

            BMIparameter(range);
        }
        
        public static void BMIparameter(double range)
        {
            if(range < 18.4)
            {
                Console.WriteLine("You are Underweight");
                DietSelector.SelectDiet();
                
            }
            else if (range >= 18.5 && range <24.9)
            {
                Console.WriteLine("You are Normal");   
                DietSelector.SelectDiet();
            }
            else if (range >= 25 && range <= 29.9)
            {
                Console.WriteLine("You are Overweight");   
                DietSelector.SelectDiet();
            }
            else if (range >= 30)
            {
                Console.WriteLine("You are Obese");
                DietSelector.SelectDiet();
            }
            else
            {
                System.Console.WriteLine("Undetermined");
            }
            return;
        }
    }
}
