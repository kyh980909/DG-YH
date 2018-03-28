using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3_과제1
{
    class Program
    {
        static void Main(string[] args)
        {
            int year; //사용자에게 년도 입력 받을 변수

            Console.Write("생년을 입력하세요: ");
            year = int.Parse(Console.ReadLine());

            switch (year % 12)
            {
                case 0:
                    Console.WriteLine("원숭이띠 입니다.");
                    break;
                case 1:
                    Console.WriteLine("닭띠 입니다.");
                    break;
                case 2:
                    Console.WriteLine("개띠 입니다.");
                    break;
                case 3:
                    Console.WriteLine("돼지띠 입니다.");
                    break;
                case 4:
                    Console.WriteLine("쥐띠 입니다.");
                    break;
                case 5:
                    Console.WriteLine("소띠 입니다.");
                    break;
                case 6:
                    Console.WriteLine("범띠 입니다.");
                    break;
                case 7:
                    Console.WriteLine("토끼띠 입니다.");
                    break;
                case 8:
                    Console.WriteLine("용띠 입니다.");
                    break;
                case 9:
                    Console.WriteLine("뱀띠 입니다.");
                    break;
                case 10:
                    Console.WriteLine("말띠 입니다.");
                    break;
                case 11:
                    Console.WriteLine("양띠 입니다.");
                    break;
            }
        }
    }
}
