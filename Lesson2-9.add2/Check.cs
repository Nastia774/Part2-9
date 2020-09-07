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
        static bool Check(string phone)
        {
            char[] num = phone.ToCharArray();

            if (phone.Length > 13 || phone.Length < 13)
            {
                return false;
            }
            else if (num[0] == '+' && num[1] == '3' && num[2] == '8' && num[3] == '0')
            {
                for (int i = 4; i < num.Length; i++)
                {
                    if (char.IsNumber(num[i]))
                        return true;
                }
            }
            return false;

        }
    }
}
