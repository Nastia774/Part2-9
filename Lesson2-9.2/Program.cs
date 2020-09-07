using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_9._2
{
    class Program
    {
        delegate int Add(int argument1, int argument2);
        delegate int Sub(int argument1, int argument2);
        delegate int Mul(int argument1, int argument2);
        delegate double Div(int argument1, int argument2);
        static void Choice(string a)
        {
            Add add = (num1, num2) => { return num1 + num2; };
            Sub sub = (num1, num2) => { return num1 - num2; };
            Mul mul = (num1, num2) => { return num1 * num2; };
            Div div = (num1, num2) =>
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Попытка деления на ноль.");
                    return default;
                }
                else
                    return (double)num1 / num2;
            };
            switch (a)
            {
                case "+":
                    {
                        Console.WriteLine($"Сложение : {add(3, 5)}");
                        break;
                    }
                case "-":
                    {
                        Console.WriteLine($"Вычитание : {sub(3, 5)}");
                        break;
                    }
                case "*":
                    {
                        Console.WriteLine($"Умножение : {mul(3, 5)}");
                        break;
                    }
                case "/":
                    {
                        Console.WriteLine($"Деление : {div(3, 5)}");
                        break;
                    }
                default:
                    break;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите арифметическое действие +, -, *, / : ");
            string sing = Console.ReadLine();
            Choice(sing);

            Console.ReadKey();
        }
    }
}
