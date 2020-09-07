using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_9.add
{
    class Program
    {
        delegate double MyDelegate(int num1, int num2, int num3);
        static void Main(string[] args)
        {
            MyDelegate myDelegate = delegate (int num1, int num2, int num3)
              {
                  return (double)(num1 + num2 + num3) / 3;
              };
            Console.WriteLine(myDelegate(2, 4, 8));


            Console.ReadKey();
        }
    }
}
