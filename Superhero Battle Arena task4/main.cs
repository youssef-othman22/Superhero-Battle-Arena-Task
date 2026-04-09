using System;

namespace n1
{
    public class main
    {
        public static void Main(string[] args)
        {

            //List<BaseHero> lst = new List<BaseHero>()
            //{
            //    new Mage("Mage1",5,7) ,
            //    new Warrior("Warrior1" , 3 , 4),
            //    new Archer("Archer1",4,8),
            //    new Mage("Mage2",4,3) ,
            //    new Warrior("Warrior2" , 8 , 9),
            //    new Archer("Archer2",2,1),
            //    new Mage("Mage1",5,7) ,
            //    new Warrior("Warrior1" , 3 , 4),
            //    new Archer("Archer3",4,8),
            //    new Mage("Mage1",5,7) ,
            //    new Warrior("Warrior1" , 3 , 4),
            //    new Archer("Archer",4,8),

            //};
            Mage mg = new Mage("mg1" , 5 , 2);
            Archer arch = new Archer("arch1", 10, 2);
            arch.Attack(mg, 2);
            mg.Introduce();
            arch.Introduce();


            Console.ReadKey();
        }

    }


}
 