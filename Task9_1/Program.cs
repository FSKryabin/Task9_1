using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Calculator");
                double a, b = 0;
                char z;
                Console.Write("Введите 1 число: ");
                a = double.Parse(Console.ReadLine());
                Console.Write("Выберите действие: (+, -, *, /, s)");
                z = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (z != 's')
                {
                    Console.Write("Введите 2 число: ");
                    b = double.Parse(Console.ReadLine());
                }
                switch (z)
                {
                    case '+':
                        Console.WriteLine("{0}+{1}={2}", a, b, a + b);
                        break;
                    case '-':
                        Console.WriteLine("{0}-{1}={2}", a, b, a - b);
                        break;
                    case '*':
                        Console.WriteLine("{0}*{1}={2}", a, b, a * b);
                        break;
                    case '/':
                        Console.WriteLine("{0}/{1}={2}", a, b, a / b);
                        break;
                    case 's':
                        Console.WriteLine("sqrt({0})={1}", a, Math.Sqrt(a));
                        break;
                    default:
                        Console.WriteLine("Ошибка");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
