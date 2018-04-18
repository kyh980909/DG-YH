using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raising_a_pet
{
    class Pet
    {
        public string name;
        public int age;
        public int happiness = 50;              // happiness 초기값 50으로 설정

        public Pet(string name, int age)        //클래스 매개변수 받아와서 이름과 나이를 클래스 변수에 대입
        {
            this.name = name;
            this.age = age;
        }

        public void Play()                      // Play메서드 happiness를 10증가 시킴 happiness가 100이 넘으면 happiness에 100을 대입해서 최대범위 지정
        {
            happiness += 10;
            if (happiness > 100)
                happiness = 100;
        }

        public void Eat()                       // Eat메서드 happiness를 20증가 시킴 happiness가 100이 넘으면 happiness에 100을 대입해서 최대범위 지정
        {
            happiness += 20;
            if (happiness > 100)
                happiness = 100;
        }

        public void Board()                     // Board메서드 happiness를 5 감소 시킴 happiness가 0보다 작아지면 happiness에 0을 대입해서 최소범위 지정
        {
            happiness -= 1;
            if (happiness < 0)
                happiness = 0;
        }

        public string Express()  // label에 happiness값 출력
        {
            string message = "";

            if (happiness > 80)
                message = "I'm so happy.";
            else if (happiness > 60)
                message = "I'm happy.";
            else if (happiness > 40)
                message = "I'm so so.";
            else if (happiness > 20)
                message = "I'm gloomy.";
            else
                message = "I'm sad.";

            return this.name + " : " + message;
        }

        public string ExpressHappiness()
        {
            string presenthappiness = happiness.ToString();

            return "현재 Happiness의 값 : " + presenthappiness;
        }
    }
}
