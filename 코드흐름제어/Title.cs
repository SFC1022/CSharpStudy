using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 코드흐름제어
{
    static class Title
    {
        public static void Gamestart()
        {
            Console.Clear();
            while (true)
            {

                Console.WriteLine("게임이 시작했습니다.");
                int a = int.Parse(Console.ReadLine());
                if (a == 1)
                {
                    Console.Clear();
                    Console.WriteLine(" ");
                    Console.WriteLine("모시꺵중!");
                    Console.WriteLine(" " +
                        "");
                }
                else if (a == 2)
                {
                    titlescreen();
                }
            }
        }

        public static void op()
        {
            Console.Clear();
            while (true)
            {

                Console.WriteLine("옵션창이 열렸습니다. 모시깽하기 = 1, 나가기 = 2");
                int a = int.Parse(Console.ReadLine());
                if (a == 1)
                {
                    Console.Clear();
                    Console.WriteLine(" ");
                    Console.WriteLine("모시꺵중!");
                    Console.WriteLine(" ");
                }
                else if (a == 2)
                {
                    titlescreen();
                }
            }
        }

        public static void titlescreen()
        {
            Console.Clear();
            Console.WriteLine(" ");
            Console.WriteLine("===(두둥 촤아아ㅏㅏㅏㅏ) 대박 멋진 게임!!!!!===");
            Console.WriteLine(" ");

            for (; ; )
            {
                Console.WriteLine("==============메뉴창==============");
                Console.WriteLine("1. 게임 시작");
                Console.WriteLine("2. 옵션");
                Console.WriteLine("3. 게임 종료");
                Console.WriteLine("==================================");
                Console.Write("선택지를 입력해주세요. : ");
                int choose = int.Parse(Console.ReadLine());

                if (choose == 1)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("게임을 시작합니다.");
                    Gamestart();
                }
                else if (choose == 2)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("옵션창을 엽니다.");
                    op();
                }
                else if (choose == 3)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("게임을 종료합니다.");
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(" ");
                    Console.WriteLine("오류 : 잘못된 입력 값입니다. 다시 입력해주세요.");
                    Console.WriteLine(" ");
                }
            }
        }
    }
}

namespace Game
{
    class player
    {
        public int HP;
        public int ATK;
        public string Name;

        public void attack(enemy enemy)
        {
            enemy.HP = enemy.HP - ATK;
        }

    }

    class enemy
    {
        public int HP;
        public int ATK;
        public string Name;

        public void enemy_attack(player player)
        {
            player .HP = player.HP - ATK;
        }
    }
}