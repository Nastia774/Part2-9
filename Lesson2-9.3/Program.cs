using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_9._3
{
    class Program
    {
        delegate double MyDelegate(MyDelegate2[] myDelegate);
        delegate int MyDelegate2();
        static int Create()
        {

            Random random = new Random();
            int num = random.Next(0, 10);
            return num;
        }
        static void Main(string[] args)
        {
            double average = default;
            MyDelegate2[] mas = new MyDelegate2[]
            { new MyDelegate2(Create), new MyDelegate2(Create), new MyDelegate2(Create) };

            MyDelegate myDelegate = delegate (MyDelegate2[] myDelegate2)
              {
                  for (int i = 0; i < myDelegate2.Length; i++)
                  {
                      average += myDelegate2[i]();
                  }
                  return average / myDelegate2.Length;
              };
            Console.WriteLine(myDelegate(mas));

            Console.ReadKey();
        }
    }
}
