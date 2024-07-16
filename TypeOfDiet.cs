namespace ChooseDiet
{
    public static class DietSelector
    {
        public static void SelectDiet()
        {
            Console.WriteLine("Choose the Dietary Approach You Wish to Take: ");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Select a number between 1 and 10 to indicate the kind of diet you want: ");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("1.Mediterranean Diet");
            Console.WriteLine("2.Ketogenic (Keto) Diet");
            Console.WriteLine("3.Paleo Diet"); 
            Console.WriteLine("4.Vegan Diet");
            Console.WriteLine("5.Vegetarian Diet");
            Console.WriteLine("6.Whole30 Diet");
            Console.WriteLine("7.DASH Diet");
            Console.WriteLine("8.Intermittent Fasting");
            Console.WriteLine("9.LowCarb Diet");
            Console.WriteLine("10.Gluten-Free Diet");
            Console.WriteLine("---------------------------------------------------------------");

            int lifestyle = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You chosed:{lifestyle}");
            SelectedDiet(lifestyle);
            Console.ReadLine();
        }

        public static void SelectedDiet(int lifestyle)
        {
            switch (lifestyle)
            {
                case 1:
                    Console.WriteLine("You have selected the Mediterranean Diet");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("Emphasizes fruits, vegetables, whole grains, legumes, nuts, and olive oil.\nIt includes moderate consumption of fish and poultry, and limited intake of red meat and sweets. It's known for its heart health benefits.");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");
                    break;
                case 2:
                    Console.WriteLine("You have selected the Ketogenic Diet");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("A high-fat, low-carbohydrate diet that puts the body into a state of ketosis, where it burns fat for fuel instead of carbohydrates.\nIt's often used for weight loss and improving insulin sensitivity.");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");
                    break;
                case 3:
                    Console.WriteLine("You have selected the Paleo Diet");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("Focuses on foods presumed to be eaten by early humans, including lean meats, fish, fruits, vegetables, nuts, and seeds.\nIt excludes processed foods, grains, legumes, and dairy products.");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");
                    break;
                case 4:
                    Console.WriteLine("You have selected the Vegan Diet");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("Excludes all animal products, including meat, dairy, and eggs. It focuses on plant-based foods such as fruits, vegetables, grains, nuts, and seeds.\nIt's often adopted for ethical, environmental, or health reasons.");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");
                    break;
                case 5:
                    Console.WriteLine("You have selected the Vegetarian Diet");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("Eliminates meat but may include dairy and eggs. There are variations like lacto-vegetarian (includes dairy), ovo-vegetarian (includes eggs),\nand lacto-ovo-vegetarian (includes both dairy and eggs).");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");
                    break;
                case 6:
                    Console.WriteLine("You have selected the Whole30 Diet");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine(" A 30-day program that eliminates sugar, alcohol, grains, legumes, soy, and dairy.\nIt's designed to reset eating habits and identify food sensitivities by reintroducing excluded foods one at a time after the 30 days.");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");
                    break;
                case 7:
                    Console.WriteLine("You have selected the DASH Diet");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("Stands for Dietary Approaches to Stop Hypertension. It emphasizes fruits, vegetables, whole grains, lean proteins, and low-fat dairy while reducing sodium, sweets, and red meats.\nIt's designed to lower blood pressure.");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");
                    break;
                case 8:
                    Console.WriteLine("You have selected the Intermittent Fasting Diet");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("n eating pattern that cycles between periods of fasting and eating.\nCommon methods include the 16/8 method (fasting for 16 hours and eating during an 8-hour window) and the 5:2 method (eating normally for 5 days and reducing calorie intake for 2 days).");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");
                    break;
                case 9:
                    Console.WriteLine("You have selected the LowCarb Diet");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("Focuses on reducing carbohydrate intake, often to promote weight loss and control blood sugar levels.\nFoods like vegetables, meat, fish, eggs, and healthy fats are emphasized, while grains, sugary foods, and starches are limited.");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");
                    break;
                case 10:
                    Console.WriteLine("You have selected the Gluten-Free Diet");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine(" Eliminates gluten, a protein found in wheat, barley, and rye. It's essential for people with celiac disease or gluten sensitivity.\nThe diet focuses on naturally gluten-free foods like fruits, vegetables, meat, and grains like rice and quinoa.");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }
}