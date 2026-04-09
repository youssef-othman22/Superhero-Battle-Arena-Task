namespace n1
{
    public class Mage : BaseHero
    {
        public Mage(string name, int health , int power)
        {
            this.Name = name;
            this.Health = health;
            this.Power = power;

        }
      //  Mage.attack(Archer,3);
        public override void Attack(BaseHero attacked , int numberOFKicks)
        {
            Type t = attacked.GetType();
            int damage = this.Power * numberOFKicks;
            attacked.RecieveDamage(damage);
            Console.Write($"Mage is Attacking {t.Name}");
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
 