using monster_game;

namespace Summoning_Monsters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====게임 시작=====");

            Player player = new Player();
            Rival rival = new Rival();

            Monsters ghospy = new ghospy();
            Monsters rabox = new rabox();
            Monsters abi = new abi();

            while (true)
            {
                Console.Write("사용할 몬스터를 선택해주세요. (1. 고스피, 2.토끼여우, 3.아비, 4.설명을 본다.) : ");
                int answer = int.Parse(Console.ReadLine());

                if (answer == 1)
                {
                    player.myMonster = ghospy;
                    rival.myMonsters = rabox;
                }
                else if (answer == 2)
                {
                    player.myMonster = rabox;
                    rival.myMonsters = abi;
                }
                else if (answer == 3)
                {
                    player.myMonster = abi;
                    rival.myMonsters = ghospy;
                }
                else if (answer == 4)
                {
                    Console.WriteLine("위스피 : (500.200.200)");
                    Console.WriteLine("스킬 : 자신의 스피드를 100 올린다.");
                    Console.WriteLine("토끼여우 : (400.300.300)");
                    Console.WriteLine("스킬 : 상대의 공격력을 50 낮춘다.");
                    Console.WriteLine("위스피 : (800.100.200)");
                    Console.WriteLine("스킬 : 상대를 한턴 스턴시킨다.");
                }
                else
                {
                    Console.WriteLine("올바르지 못한 입력입니다. 다시 시도해주십시오.");
                }
            }
        }
    }
}
