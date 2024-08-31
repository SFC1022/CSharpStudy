namespace 클래스_상속
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("클래스 상속");

            player player = new player();
            player.HP = 100;
            player.AttackPower = 10;

            Slime slime = new Slime();
            slime.HP = 50;
            slime.AttackPower = 5;

            bear bear = new bear();
            bear.HP = 70;
            bear.AttackPower = 5;

            player.Attack(slime);

            slime.BeAttacked(player);

            bear.Attack(player);

            slime.SpecialAttack(); // 슬라임이 분열했다.
            bear.SpecialAttack(); // 곰이 울부짖었다.

        }
    }
}
