﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 클래스_상속
{

    /*
     *  클래스 : 플레이어와 몬스터 전투시스템
     *  플레이어, 몬스터
     *  class Player { }
     */

    /*
     *  기능 : 플레이어의 기능을 만든다.
     *  1. 공격한다.
     *  2. 휴식한다.
     *  3. 도망친다.
     */

    internal class player
    {
        public int HP;
        public int AttackPower;

        public void Attack(Monster monster)
        {
            // 슬라임의 현재 체력 - 플레이어의 공격력]
            monster.HP = monster.HP - AttackPower;
            Console.WriteLine("===플레이어의 공격!===");

            //Slime.BeAttacked(this);
        }

        public void BeAttacked(Monster monster)
        {
            //플레이어 체력 - 슬라임의 공격력
            HP = HP - monster.AttackPower;
        }

        public void Show()
        {
            Console.WriteLine($"플레이어의 체력 : {HP}");
            Console.WriteLine($"플레이어의 공격력 : {AttackPower}");
        }
    }
}
