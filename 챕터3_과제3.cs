using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3_과제3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("학년을 입력하세요: ");
            int level = int.Parse(Console.ReadLine());      //레벨을 입력 받음

            switch (level)      //레벨에 따른 수강해야하는 전공 학점 출력
            {
                case 1:
                    Console.WriteLine("수강해야 하는 전공 학점: 12학점");
                    break;
                case 2:
                    Console.WriteLine("수강해야 하는 전공 학점: 18학점");
                    break;
                case 3:
                    Console.WriteLine("수강해야 하는 전공 학점: 10학점");
                    break;
                case 4:
                    Console.WriteLine("수강해야 하는 전공 학점: 18학점");
                    break;
            }
        }
    }
}
