using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 개미수열
{
    class Program
    {
        static void Main(string[] args)
        {
            string[ , ] arrA = new string[20, 10]; // 수열을 저장할 2차원 배열

            int k;
            int cnt; // 같은 숫자가 몇번 나왔는지 세는 변수
            bool newNum = false; //새로운 숫자가 나오는지 구별 할 변수

            arrA[0, 0] = "1"; // 첫번째 수열은 1

            for (int i = 0; i < 20; i++)
            {
                k = 0;
                cnt = 1;
                while (k < 9 && (arrA[i, k] != null))  //1. 배열 인덱스 범위 지정 2. null을 만나면 반복문 종료
                {
                    if (i < 19)                                    // 배열 인덱스 범위 지정
                        arrA[i + 1, k] = arrA[i, k];               // 이전 수열을 다음 수열에 복사 - 다음 수열에 이전 수열에서 추가된 값을 적용하기 위함
                    if (k < 9 && (arrA[i, k] == arrA[i, k + 1]))   //1. 배열 인덱스 범위 지정
                        cnt++;                                     //2. 현재 인덱스의 숫자와 다음 인덱스의 숫자가 같으면 cnt값 1 증가
                    if (cnt > 1)                                   // 같은숫자가 2번 이상나오면 새로운 숫자가 나올 것을 암시
                        newNum = true;                             // ?
                    k++;
                }
                if (i < 19)                                        // 배열 인덱스 범위 지정
                    arrA[i + 1, k] = cnt.ToString();
            }
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(arrA[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
