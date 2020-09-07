using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson2_9.add2
{
    partial class Program
    {
        delegate int Notifier(string name, string phone, int code);
        delegate bool Verifier(string phone);
        static int Write(string name, string phone, int code)
        {
            code = Create();
            Console.WriteLine($"Пользователь {name} с номером телефона {phone}. Ваш код {code}");
            return code;
        }
        static int Create()
        {
            Random random = new Random();
            int num = random.Next(1000, 10000);
            return num;
        }
        static void Main(string[] args)
        {
        metka:
            Console.Write("Введите имя : ");
            string name = Console.ReadLine();
            Console.Write("Введите номер телефона : ");
            string phone = Console.ReadLine();
            Console.WriteLine(phone);
            Verifier verifier = new Verifier(Check);
            bool b = verifier(phone);
            int code = default;
            if (b == true)
            {
                Notifier notifier = new Notifier(Write);
                code = notifier(name, phone, code);
            }
            else
            {
                Console.WriteLine("Неверный номер телефона.");
                Console.Clear();
                Thread.Sleep(5000);
                goto metka;
            }
            Console.Write("Введите код : ");
            int newcode = int.Parse(Console.ReadLine());
            if (newcode == code)
            {
                Console.WriteLine($"Добро пожаловать {name} !");
            }

            Console.ReadKey();
        }
    }
}
