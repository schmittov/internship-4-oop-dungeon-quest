namespace Library.Domain.Repositories.Heroes
{
    public class Gladiator : Hero
    {

        public Gladiator(string name, int maxHealthPoints, int healthPoints, int damage, int level, int experience) 
            :base(name, maxHealthPoints, healthPoints, damage, level, experience)
        {
        }

        public static void RageAttack()
        {
            Console.WriteLine("Izgubio si 15% hp");
            Console.WriteLine("rage attack");
        }
    }
}
