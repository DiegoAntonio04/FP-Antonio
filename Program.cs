using System;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;
using UserAccountManagement;
using BMIADULT;
using ChildrenBMI;
using System.Runtime.InteropServices;


namespace DietProgram
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Program Intro/Design
            Console.WriteLine("Hello! Welcome to A Diet Program!!");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Sign up by using your ID, User, and Password: ");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++");
            Console.Write("Press any button to start signing up!");
            Console.ReadLine();

            //User Input/Sign Up
            Console.Write("Enter your Id Number:");
            int id =Convert.ToInt16(Console.ReadLine())!;
            Console.Write("Enter your User Name:");
            string acc=Console.ReadLine()!;
            Console.Write("Enter your Password:");
            string password=Console.ReadLine()!;
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++");
            
            UserAccountManager.AddUser(id,acc,password);
            UserAccountManager.DisplayUsers();
            Console.ReadLine();
            Console.Clear();
            //Warning on user
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("We must verify that you are of legal age before allowing you to use this program.");
            Console.WriteLine("(The only function accessible to those under the age of twenty(20) is the calculation of your body mass index. )");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Disclamer!The use of health applications should not replace professional medical advice, diagnosis, or treatment.");
            Console.Write("Always consult with a qualified healthcare provider regarding any medical condition or before making any changes to your health");
            Console.WriteLine("regimen.Health applications may provide useful information and support, but they are not a substitute for personalized medical care.");
            Console.WriteLine("If you experience any adverse effects or have concerns about your health, seek immediate medical attention.");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------");
            //Age Verifier
            Console.WriteLine("Do you consider yourself an Adult?(18+):");
            Console.WriteLine("Yes is indicated by Y, and no by N. ");
            string choice= Console.ReadLine().ToUpper();
            
            if(choice == "Y")
            {
                {
                    GrownUPBMI.OldBMICalc();
                }
               
            }
            else if (choice == "N")
            {
                {
                    KidsBMi.GetUserInput();
                    KidsBMi.CalculateBMI();
                    KidsBMi.DisplayBMI();
                }
            }
            else
            {
                Console.WriteLine("Invalid Input!!");
            
            }
        }       
    }
}