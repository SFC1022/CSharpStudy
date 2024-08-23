using 메이플스토리;
    
namespace 클래스와_메소드
{
    internal class Program
    {
        static void PlayerTurn(player player, Slime slime)
        {
            Console.WriteLine(" ");
            Console.WriteLine("1. 공격한다.");
            Console.WriteLine("2. 휴식한다.");
            Console.WriteLine("3. Q날리기");
            Console.Write("말파이트가 할 행동을 선택해주세요 : ");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                slime.Attack(player);
                player.Attack(slime);
                

            }
            else if (userInput == 2)
            {
                slime.Attack(player);
                player.Rest();
                
            }

            else if (userInput == 3)
            {
                slime.Attack(player);
                player.Q(slime);

            }
        }


        static void Main(string[] args)
        {
            네임스페이스 ns = new 네임스페이스();
            ns.show();

            /*
             * 클래스 사용하는 방법
             * (이름공간.Slime) (클래스이 이름 변수) = new 메이플스토리.Slime();
             * 
             */

            메이플스토리.Slime slime = new 메이플스토리.Slime();
            slime.Name = "모데카이저";
            slime.HP = 300;
            slime.AttackPower = 15;
            //slime.MoveSpeed = 2.2f;
            slime.Show();

            /* 초록 달팽이 (무쓸모)
            메이플스토리.snail snail = new 메이플스토리.snail();
            snail.Name = "초록 달팽이";
            snail.HP = 10;
            snail.AttackPower = 2;
            snail.MoveSpeed = 1.2f;
            snail.Show();
            */

            메이플스토리.player player = new 메이플스토리.player();
            player.Name = "말파이트";
            player.HP = 350;
            player.AttackPower = 10;
            //player.MoveSpeed = 3.2f;
            player.Show();

            while (true)
            {
               
                PlayerTurn(player, slime);
                
                slime.Show();
                Console.WriteLine(" ");
                player.Show();

                if (player.HP <= 0)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("말파이트가 사망했습니다. 라인전에서 패배했습니다.");
                    break;
                }

                if (slime.HP <= 0)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("모데카이저를 처치했습니다. 라인전에서 승리했습니다.");
                    break;
                }
            }
        }   
    } 
}