using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_과제1
{
    class Program
    {
        static void Main(string[] args)
        {
            int inch; //inch를 입력받을 변수
            double cm; //cm를 입력받을 변수

            Console.Write("Inch: ");
            inch = int.Parse(Console.ReadLine());
            cm = inch * 2.54;
            Console.WriteLine(inch + "는 " + cm + "입니다.");
        }
    }
}
