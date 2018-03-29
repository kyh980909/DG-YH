using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4_과제3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5]; // 5칸 짜리 배열 생성
            int max, min;           // 최댓값과 최솟값을 저장할 변수 생성 


            for (int i = 0; i < 5; i++)
            {
                Console.Write("숫자를 입력해주세요: ");
                num[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("-----------------------------");

            max = num[0];
            min = num[0];

            for (int i = 1; i < 5; i++)
            {
                if (max < num[i])
                    max = num[i];
            }

            for (int i = 1; i < 5; i++)
            {
                if (min > num[i])
                    min = num[i];
            }

            Console.WriteLine("가장 큰 수: {0}", max);
            Console.WriteLine("가장 작은 수: {0}", min);
        }
    }
}
