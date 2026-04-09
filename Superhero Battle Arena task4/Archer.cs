namespace n1
{
    public class Archer : BaseHero
    {
        public Archer(string name, int health, int power)
        {
            this.Name = name;
            this.Health = health;
            this.Power = power;

        }
        public override void Attack(BaseHero attacked , int numberOFKicks)
        {
            Type t = attacked.GetType();
            int damage = this.Power * numberOFKicks;
            attacked.RecieveDamage(damage);
            Console.Write($"Warrior is Attacking {t.Name}");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".\n");
        }
       
    }


}
 