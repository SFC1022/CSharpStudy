using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 코드흐름제어
{
    static class while반복문
    {
        public static void Show ()
        {
            Console.WriteLine("while 반복문 강의");

            int number = 0;

            // while() 조건식이 false가 될때까지 반복한다.
            while(number < 10) // 조건식
            {
                Console.WriteLine(number);
                number = number + 1; // number에 1을 더해서 다시 넣어준다.
            }
            number = 0;
            // while(true) 무한 반복은 실행 후에 조건문으로 탈출하는 방법
            while(true)
            {
                Console.WriteLine(number);
                number = number + 1;
                if (number == 10)
                {
                    break;
                }
            }

            Console.WriteLine("---------------경계선---------------");

            // while문을 언제 사용하는가?
            // 얼마 만큼 반복해야 할지 잘 모르겠을 때 while 반복문을 쓰면 좋다.

            // 1부터 10까지의 숫자 중에서 짝수만 출력하는 코드를 작성하라. for 반복문, while 반복문
            int num2 = 0;
            while (num2 <= 10)
            {
                if (num2 % 2 == 0) // 짝수라면...
                {
                    Console.WriteLine(num2);
                }
                num2 = num2 + 1;
            }
            // 1. 탈출해야 하는 조건
            // 2. 반복해서 실행해야 할 코드

            Console.WriteLine("---------------경계선---------------");
            Console.WriteLine("반복문 예제 문제");

            // 1부터 100 사이의 3의 배수만 출력하는 코드

            int num3 = 1;
            while (num3 <= 100)
            {
                if (num3 % 3 == 0)
                {
                    Console.WriteLine($"3의 배수의 값 : {num3}");
                }
                num3++;
            }
        }
    }
}
