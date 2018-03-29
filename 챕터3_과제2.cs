using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3_과제2
{
    class Program
    {
        static void Main(string[] args)
        {
            int month;      //달을 입력받을 변수 선언

            Console.Write("몇 월 인가요? ");
            month = int.Parse(Console.ReadLine());      //몇 월 인지 입력 받기

            switch (month)  //입력받은 월에 따른 계절 출력
            {
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄 입니다.");
                    break;

                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름 입니다.");
                    break;

                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가을 입니다.");
                    break;

                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울 입니다.");
                    break;

                default:
                    Console.WriteLine("잘못입력하셨습니다.");
                    break;
            }
        }
    }
}
