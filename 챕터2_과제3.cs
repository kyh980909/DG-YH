using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_과제3
{
    class Program
    {
        static void Main(string[] args)
        {
            int r; //반지름 변수

            Console.Write("원의 반지름을 입력하세요: ");
            r = int.Parse(Console.ReadLine());  //원의 반지름 입력받기

            Console.WriteLine("둘레: " + 2 * Math.PI * r);    //원의 둘레 출력
            Console.WriteLine("넓이: " + Math.PI * r * r);    //원의 넓이 출력
        }
    }
}
