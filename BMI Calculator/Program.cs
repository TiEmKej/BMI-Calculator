using System;

namespace BMI_Calculator
{
    class Program
    {
        static void Main()
        {
            Bmi();
            Console.ReadLine();
        }
        static void Bmi()
        {
            Console.Write("Enter your height in meters (Exmaple: '1,75'\nHeight: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your weight in meters (Exmaple: '75,5'\nWeight: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            double bmi = Math.Round(weight / (height * height), 2);
            Console.WriteLine($"Your BMI is equal to {bmi}");
            Scale(bmi);
        }
        static void Scale(double bmi)
        {
            Console.WriteLine("\n         BMI Scale\n" +
                              "Underweight      = < 18,5\n" +
                              "Normal weight    = 18.5-24.9\n" +
                              "Overweight       = 25–29.9\n" +
                              "Obesity          = >= 30\n");
            if(bmi < 18.5)
            {
                Console.WriteLine("You're underweight!");
            }else if(bmi >= 18.5 && bmi <= 24.9)
            {
                Console.WriteLine("Your weight is normal");
            }else if(bmi >= 25 && bmi <= 29.9)
            {
                Console.WriteLine("You're overweight!");
            }else if(bmi >= 30)
            {
                Console.WriteLine("You'are obese!");
            }
        }
    }
}
