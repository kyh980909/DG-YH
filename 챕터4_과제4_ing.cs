using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4_과제4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arrA = new int[20, 6]; // 수열을 저장할 2차원 배열
            int k, m, l;
            int[,] cnt = new int[20, 5]; // 같은 숫자가 몇번 나왔는지 세는 배열
            int[,] newNum = new int[20, 3]; //새로운 숫자를 만났을 때 그 숫자를 저장 할 변수


            arrA[0, 0] = 1; // 첫번째 수열은 1

            for (int i = 0; i < 20; i++)
            {
                newNum[i, 0] = arrA[i, 0];
                k = 0;
                m = 0;
                l = 0;
                cnt[i , 0] = 1;
                while (k < 9 && arrA[i, k] != 0)                      //1. 배열 인덱스 범위 지정 2. null을 만나면 반복문 종료 - 수열을 읽는 부분
                {
                    //if (i < 19)                                     // 배열 인덱스 범위 지정
                    //    arrA[i + 1, k] = arrA[i, k];                // 이전 수열을 다음 수열에 복사 - 다음 수열에 이전 수열에서 추가된 값을 적용하기 위함
                    if (i == 0)
                        break;
                    if (arrA[i, k] == arrA[i, k + 1])                 //1. 배열 인덱스 범위 지정
                        cnt[i, m]++;                                  //2. 현재 인덱스의 숫자와 다음 인덱스의 숫자가 같으면 cnt값 1 증가
                    //if (cnt[i, m] > 1)                                // 같은숫자가 2번 이상나오면 새로운 숫자가 나올 것을 암시
                    //{
                    if (arrA[i, k + 1] != 0 && arrA[i, k] != arrA[i, k + 1])    //현재 인덱스와 다음 인덱스의 값이 다르면 newNum을 새롭게 바꿔주고 m 1증가 시켜서 cnt배열 바꿔주기
                    {
                        newNum[i, l] = arrA[i, k + 1];
                        l++;
                        m++;
                        cnt[i, m] = 1;
                    }
                    //}
                    //if (i < 19)
                    //    arrA[i + 1, k] = cnt[i, m];
                    
                    k++;
                }
                k = 0;
                m = 0;
                l = 0;
                while ((i < 19 && k < 9) && (arrA[i, k] != 0))  //1. 배열 인덱스 범위 지정 2. null을 만나면 반복문 종료 - 수열을 말하는 부분 - @여길 고쳐야 함@
                {                    
                    if (k == 0)
                    {
                        //arrA[i + 1, k + 1] = cnt[i, k];
                        arrA[i + 1, k] = 1;
                    }
                    else
                    {
                        if (k % 2 == 1)
                        {
                            arrA[i + 1, k] = cnt[i, m];
                            m++;
                        }
                        else
                        {
                            arrA[i + 1, k] = newNum[i, l];
                            l++;
                        }
                    }
                    k++;
                }
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
