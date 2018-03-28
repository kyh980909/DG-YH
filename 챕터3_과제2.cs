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
            int month;

            Console.Write("몇 월 인가요? ");
            month = int.Parse(Console.ReadLine());

            switch (month)
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
