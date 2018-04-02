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
            string[] arrayA = new string[500];
            int[] arrayB = new int[500];

            int num = 1; // 수열을 저장할 변수
            int cnt = 0; // 카운트 변수
            int j = 0, k = 0;   // k는 arrayA의 인덱스
            int newNum = 0;

            for (int i = 0; i < 20; i++)
            {
                arrayA[i] = num.ToString("0");    //첫 번째 수열: 1

                while (arrayA[j] != null)
                {
                    newNum = 0;     // 이전 숫자와 다음 숫자가 다를 경우가 몇번 나왔는지 세는 변수
                    cnt = 0;        // 같은 숫자가 몇개인지 세는 변수
                    while (arrayA[k] != null && arrayA[k] != arrayA[k + 1])  // 1. null값을 만나면 반복문 탈출
                    {                                                        // 2. 다른 숫자가 나올때 까지 반복                  
                        cnt++;
                        k++;
                        if (cnt > 1)
                        {
                            newNum++;
                        }
                        if (newNum < 2)
                        {
                            j++;
                            arrayA[j] = cnt.ToString();
                        }
                        else if (newNum > 1)
                        {
                            arrayA[j] = cnt.ToString();
                        }
                    }
                }
            }
        }
    }
}
