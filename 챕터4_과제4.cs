﻿using System;
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
            int k, m, l, j;                         // 각 배열들의 인덱스를 이용할 변수
            int[,] arrA = new int[20, 500];         // 수열을 저장할 2차원 배열 - 1차원은 수열 저장 - 2차원은 몇 번째 수열인지 저장
            int[,] cnt = new int[20, 500];          // 같은 숫자가 몇번 연속해서 나왔는지 세는 배열 - 1차원은 카운트 값 저장 - 2차원은 몇 번째 수열인지 저장
            int[,] newNum = new int[20, 500];       // 현재 인덱스 숫자와 다음 인덱스 숫자가 다를때 다음 인덱스 숫자를 저장할 배열 - 1차원은 새로운 숫자 저장 - 2차원은 몇 번째 수열인지 저장

            for (int i = 0; i < 20; i++)
            {
                arrA[i, 0] = 1;
                k = 0;
                m = 0;
                l = 0;
                cnt[i , 0] = 1;
                //-------------------------------------------------------개미 수열 읽는 부분 ---------------------------------------------------//
                while (k < 498 && arrA[i, k] != 0)                    // 배열 인덱스 범위 조건 && null을 만나면 반복문 종료
                {
                    if (i == 0)                                       // 맨 처음 수열은 1이기 때문에 더 이상 아래 코드들을 진행할 필요가 없음
                        break;
                    if (arrA[i, k + 1] != 0)                          // 인덱스 범위 안넘기기 위한 기본 조건
                    {
                        if (arrA[i, k] == arrA[i, k + 1])             //1. 현재 인덱스의 숫자와 다음 인덱스의 숫자가 같으면 cnt값 1 증가
                            cnt[i, m]++;                                  
                        else
                        {                                             //2. 다를 경우 newNum에 새로 나온 숫자 대입
                            newNum[i, l] = arrA[i, k + 1];
                            m++;                                      //3. cnt배열의 m인덱스 1 증가
                            l++;                                      //4. newNum배열의 l인덱스 1 증가
                            cnt[i, m] = 1;                            //5. cnt배열의 m번째 인덱스 1로 초기화
                        }
                    }              
                    k++;
                }
                //-------------------------------------------------------개미 수열 쓰는 부분 ---------------------------------------------------//
                k = 1;
                m = 0;
                l = 0;
                while ((i < 19 && k < 498) && cnt[i, m] != 0)       // 배열 인덱스 범위 조건 && 카운트 배열에 들어있는 값만 사용하기 위한 조건
                {
                    if (k % 2 == 1)                                 // 수열의 짝수번 째는 숫자가 몇 번 나왔는지를 나타낸다. 하지만 배열의 인덱스는 0부터 시작하기 때문에 k가 홀수 일 때 cnt를 대입한다.
                    {
                        arrA[i + 1, k] = cnt[i, m];
                        m++;                                        // 대입한 후에는 다음 나올 숫자가 몇 번 나왔는지를 대입하기위해 cnt의 1차원 배열 인덱스 값을 1증가 시킨다.
                    }
                    k++;                                            // 수열의 1차원 배열 인덱스 값을 1 증가 시킨다.
                }

                k = 1;                                              // newNum도 수열의 1차원 배열 1번째 인덱스 부터 검사하면서 대입해야 하기 때문에 1로 초기화

                while (((i > 1 && i < 19) && k < 498) && (newNum[i, l] != 0)) // 배열 인덱스 범위 조건 && 카운트 배열에 들어있는 값만 사용하기 위한 조건
                {
                    if (k % 2 == 0)                                 // 수열의 홀수번 째는 새로운 숫자를 나타낸다. 하지만 배열의 인덱스는 0부터 시작하기 때문에 k가 홀수 일 때 newNum을 대입한다.
                    {
                        arrA[i + 1, k] = newNum[i, l];
                        l++;                                        // 대입한 후에는 다음 나올 숫자가 몇 번 나왔는지를 대입하기위해 cnt의 1차원 배열 인덱스 값을 1증가 시킨다.
                    }
                    k++;                                            // 수열의 1차원 배열 인덱스 값을 1 증가 시킨다.
                }
            }

            for (int i = 0; i < 20; i++)                            // 1번 부터 20번 수열까지 출력하는 for문
            {
                j = 0;
                Console.WriteLine("{0}번 수열", i + 1);
                Console.WriteLine("==========================================================================");
                while (arrA[i, j] != 0)                             // 처음 배열이 다 0으로 초기화 되어 있기 때문에 0을 제외하여 출력하기 위해 수열의 1차원 배열이 0을 만나면 while을 빠져나오도록 조건 설정
                {                    
                    Console.Write(arrA[i, j]);                      // 수열 출력
                    if (j == 499)                                   // 인덱스 범위 넘어가는걸 예외처리
                        break;
                    j++;
                }
                Console.WriteLine();
                Console.WriteLine("==========================================================================");
            }
        }
    }
}