using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAndTimeTackPractic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dateString1 = "2024-06-15";
            string dateString2 = "15-06-2024"; 

            Console.WriteLine("Использование метода Parse():");
            try
            {
                DateTime date1 = DateTime.Parse(dateString1);
                Console.WriteLine(date1); 
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка формата даты");
            }

            Console.WriteLine("\nИспользование метода TryParse():");
            DateTime result;
            bool success = DateTime.TryParse(dateString2, out result);
            if (success)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Ошибка преобразования");
            }

            Console.WriteLine("\nИспользование метода ParseExact():");
            try
            {
                DateTime res = DateTime.ParseExact(dateString1, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                Console.WriteLine(res); 
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка формата даты");
            }

            Console.WriteLine("\nИспользование метода TryParseExact():");
            string dateString3 = "15-06-2024";
            bool resultTryParseExact = DateTime.TryParseExact(dateString3, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime exactResult);
            if (resultTryParseExact)
            {
                Console.WriteLine(exactResult); 
            }
            else
            {
                Console.WriteLine("Ошибка преобразования");
            }

            Console.ReadLine();
        }
    }
}
