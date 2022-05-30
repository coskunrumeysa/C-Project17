//Beni Yaratan Elbet Yolumu Gösterir .Şuara 78.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number1;
            double number2;
            double sum;

            Console.WriteLine("Please enter first number:");
            number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter second number:");
            number2 = Convert.ToDouble(Console.ReadLine());

            sum = number1 + number2;

            Console.WriteLine(" Sum Of Two Numbers:"+" "+ sum);

            Console.Read();
            

        }
    }
}
