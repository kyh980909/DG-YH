using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_과제2
{
    class Program
    {
        static void Main(string[] args)
        {
            int kg; //kg을 입력받을 변수
            double pound; //kg을 pound로 변환해서 저장할 변수

            Console.Write("kg: ");
            kg = int.Parse(Console.ReadLine());

            pound = kg * 2.20462262;

            Console.WriteLine(kg + "kg은 " + pound + "입니다.");
        }
    }
}
