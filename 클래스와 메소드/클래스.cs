using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 강민찬.수업내용;
using 메이플스토리;

/*
 * using : 이름 공간을 사용해라
 * using 이름공간.이름공간;
 * -> 네임 스페이스를 앞에 붙이지 않아도 그 공간안에 있는 코드를 사용할 수 있다.
 */

namespace 강민찬
{
    namespace 수업내용
    {
        /*
         * 클래스
         * 사용자 정의 데이터 유형입니다. -> int, float, string, char
         * 클래스를 이용하여 객체를 생성하고 그 객체 내부에 있는 변수와 메소드를 이용하여 데이터에 접근하고 사용할 수 있는 집합체 입니다.
         */


        /*
         * 1. 클래스의 선언
         * class 이름 { }
         */

        // 슬라임

        class Monster
        {
            // 공격한다 (행동)

            // 체력
            // 공격력
            // 방어력

        }

        /*
         * 2. 클래스의 사용
         */

        class Test
        {

        }
    }
}

namespace 메이플스토리
{
    class Slime
    {
        // 슬라임의 체력은 50입니다. 실수형, 정수형

        /*
         * 접근 지정자
         * 1. publc   : 공공의, 외부에서 전부 사용할 수 있게 하라
         * 2. private : class 내부에서만 사용해라, 접근 지정자를 명시하지 않으면 자동으로 private 선언이 된다.
         */

        public int HP;
        public int AttackPower;
        public string Name;
        //public float MoveSpeed;

        public void BeAttacked(int damaged)
        {
            HP = HP - damaged;
        }

        public void Attack(player player)
        {
            // 슬라임의 공격력으로 플레이어의 체력을 깍는다.
            Console.WriteLine(" ");
            Console.WriteLine("모데카이저가 말파이트를 공격했습니다!");
            player.HP = player.HP - AttackPower;
        }

        public void Show()
        {
            Console.WriteLine($"{Name}의 체력 : {HP}");
            Console.WriteLine($"{Name}의 공격력 : {AttackPower}");
            //Console.WriteLine($"{Name}의 이동속도 : {MoveSpeed}");

        }
    }

    class snail
    {
        public int HP;
        public int AttackPower;
        public string Name;

        public void Show()
        {
            Console.WriteLine($"{Name}의 체력 : {HP}");
            Console.WriteLine($"{Name}의 공격력 : {AttackPower}");

        } 
    }
    class player
    {
        public string Name;
        public int HP;
        public int AttackPower;
        public float MoveSpeed;

        /*
         * 메소드 : 일련의 코드를 하나의 이름 아래 묶는 것입니다.
         * 묶인 코드를 이름을 불러주는 것만으로 실행할 수 있습니다.
         * 메소드를 호출하는 것을 Call method (메소드 호출)
         */

        /*
         * (접근지정자) + (반환값) + (메소드의 이름) + () + {}
         *   public       void          Show()  { 묶인 코드 내용들 }
         *   
         *   접근 지정자 : private, public, -> public 선언을 해주세요
         *   반환값이 없는 경우 : void
         *   반환값이 있는 경우 : int(정수형), float(실수형), string(문자열), Class이름(사용자 정의형) 반환하라...
         *   메소드의 이름 : Show+()+;    1. Show(이름) 2. 소괄호 ( ) 3. ; => 3개의 기호가 합쳐져서 Show 메소드 안에 있는 코드들을 호출한다.
         */

        int ReturnHP()
        {
            // 반환값이 있는 함수인 경우에는 return + 변수의 이름 + ; => 해당하는 변수 값을 반환한다.
            return HP;
        }

        string ReturnName()
        {
            return Name;
        }

        float ReturnMoveSpeed()
        {
            return MoveSpeed;
        }

        // 슬라임이 공격하는 메소드를 만들어보세요
        // 슬라임이 공격할 대상이 필요합니다

        public void Attack(Slime slime)
        {
            slime.HP = slime.HP - AttackPower;

            Console.WriteLine($"말파이트가 {slime.Name}을 공격했습니다!");
            Console.WriteLine($"------------------결과-------------------");
        }

        public void Rest()
        {
            HP = HP + 50;
            Console.WriteLine("말파이트가 물약을 먹었습니다!");
            Console.WriteLine($"------------------결과-------------------");
            Console.WriteLine("말파이트의 체력을 회복했습니다!");
        }

        public void Q(Slime slime)
        {
            slime.HP = slime.HP - 25;
            Console.WriteLine("말파이트가 Q를 사용했습니다!");
            Console.WriteLine($"------------------결과-------------------");
        }

        public void Show()
        {
            Console.WriteLine($"{Name}님의 체력 : {HP}");
            Console.WriteLine($"{Name}님의 공격력 : {AttackPower}");
            //Console.WriteLine($"{Name}님의 이동속도 : {MoveSpeed}");
        }
    }
 }

