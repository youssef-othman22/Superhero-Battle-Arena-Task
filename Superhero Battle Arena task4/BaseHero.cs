
namespace n1
{
    
        public abstract class BaseHero
        {
            public string Name { protected set; get; }
            public int Health { protected set; get; }
            public int Power { protected set; get; }
          

             public abstract void Attack(BaseHero attacked , int numberOFKicks);
             public void RecieveDamage(int damage) => this.Health = (damage > this.Health) ? 0 : (Health - damage);
        public virtual void Introduce()
        {
            Type type = this.GetType();
            Console.WriteLine($"Name : {type.Name}\n" +
                              $"Health : {this.Health}\n" +
                              $"Power : {this.Power}\n");

        }
        public void Heal()
        {
            Health += 20;
        }
        public void Heal(int amount)
        {
            Health += amount;
        }
        public override string ToString()
        {
            return $"Name:{Name}\tHealth:{Health}\tPower:{Power} ";
        }
    }

    
}
 