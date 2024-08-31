using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Summoning_Monsters
{
    internal class Monsters
    {
        public string name;
        public int HP;
        public int ATK;
        public int SPD;
        public int skillcount;
        public int debuff;

        public void show()
        {
            Console.WriteLine($"{name}의 체력 : {HP}");
            Console.WriteLine($"{name}의 공격력 : {ATK}");
            Console.WriteLine($"{name}의 스피드 : {SPD}");
        }

        public void Attack(Monsters otherMon)
        {
            otherMon.HP = otherMon.HP - ATK;
            Console.WriteLine($"현재 체력 {HP}");
        }
    }

    class ghospy : Monsters // 체력500 공격200 스피드 200
    { 
        public void Skill()
        {
            // 스피드 100 증가
            SPD = SPD + 100;
        }

    }

    class rabox : Monsters // 체력400 공격300 스피드300
    {
        public void Skill(Monsters otherMon)
        {
            // 상대 공격력 50 감소
            otherMon.ATK = otherMon.ATK - 50;
        }

    }

    class abi : Monsters // 체력800 공격 100 스피드200
    {
        public void Skill(Monsters otherMon)
        {
            // 상대 한턴 스턴
            otherMon.debuff = 1;
        }

    }
}
