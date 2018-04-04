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
            int[,] arrA = new int[20, 20]; // 수열을 저장할 2차원 배열
            int k, m, l, j;
            int[,] cnt = new int[20, 20]; // 같은 숫자가 몇번 나왔는지 세는 배열
            int[,] newNum = new int[20, 20]; //새로운 숫자를 만났을 때 그 숫자를 저장 할 변수


            arrA[0, 0] = 1; // 첫번째 수열은 1

            for (int i = 0; i < 20; i++)
            {
                arrA[i, 0] = 1;
                k = 0;
                m = 0;
                l = 0;
                cnt[i , 0] = 1;
                while (k < 19 && arrA[i, k] != 0)                      //1. 배열 인덱스 범위 지정 2. null을 만나면 반복문 종료 - 수열을 읽는 부분
                {
                    if (i == 0)
                        break;
                    if (arrA[i, k + 1] != 0)  //기본 조건
                    {
                        if (arrA[i, k] == arrA[i, k + 1])             //1. 현재 인덱스의 숫자와 다음 인덱스의 숫자가 같으면 cnt값 1 증가
                            cnt[i, m]++;                                  
                        else
                        {                                             //2. 다를 경우 newNum에 새로 나온 숫자 대입
                            newNum[i, l] = arrA[i, k + 1];
                            m++;                                      //3. cnt배열의 m인덱스 1 증가
                            l++;
                            cnt[i, m] = 1;                            //4. cnt배열의 m번째 인덱스 1로 초기화
                        }
                    }              
                    k++;
                }
                k = 1;
                m = 0;
                l = 0;
                while ((i < 19 && k < 20) && cnt[i, m] != 0)
                {
                    if (k % 2 == 1)
                    {
                        arrA[i + 1, k] = cnt[i, m];
                        m++;
                    }
                    k++;
                }
                k = 1;
                while (((i > 1 && i < 19) && k < 20) && (newNum[i, l] != 0))
                {
                    if (k % 2 == 0)
                    {
                        arrA[i + 1, k] = newNum[i, l];
                        l++;
                    }
                    k++;
                }
            }

            for (int i = 0; i < 20; i++)
            {
                j = 0;
                while (arrA[i, j] != 0)
                {
                    Console.Write(arrA[i, j]);
                    if (j == 18)
                        break;
                    j++;
                }             
                Console.WriteLine();
            }
        }
    }
}
