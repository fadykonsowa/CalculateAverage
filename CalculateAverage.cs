using System;
using CalculateAverageLib;

class CalculateAverage
{
    static void Main(string[] args)
    {
        List<double> numbersList = new List<double>();

        Console.WriteLine("Enter the numbers one by one.\nWhen you're finished, type 's' and then press Enter.\n");

        while (true)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();

            // التحقق من انتهاء الإدخال
            if (input.ToLower() == "s")
                break;

            // محاولة تحويل الإدخال إلى رقم
            if (double.TryParse(input, out double number))
            {
                numbersList.Add(number);
            }
            else
            {
                Console.WriteLine("The entered value is not a valid number, please try again.");
            }
        }

        // تحويل القائمة إلى مصفوفة
        double[] numbers = numbersList.ToArray();

        // حساب المتوسط باستخدام المكتبة
        double result = AverageSolution.FindAverage(numbers);

        Console.WriteLine($"Average numbers\n: {result}");
        Console.ReadKey();
    }
}