using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World !");
            Console.WriteLine("cw + Tab x2");
            Console.WriteLine("Enter something");
            string textFromUser;
            textFromUser = Console.ReadLine();
            Console.WriteLine("Your string is \"" + textFromUser + "\"");

            //Convert - конвертирование типов

            Console.WriteLine("Insert first number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert second number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum of numbers is " + (firstNumber+secondNumber));

            // Замена разделителя "," в дробных числах на разделитель "."

            string str = "1.9";
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };

            double a = Convert.ToDouble(str, numberFormatInfo);
        }
    }
}
