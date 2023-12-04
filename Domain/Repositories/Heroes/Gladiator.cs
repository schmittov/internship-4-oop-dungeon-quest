namespace Library.Domain.Repositories.Heroes
{
    public class Gladiator : Hero
    {

        public Gladiator(string name, int maxHealthPoints, int healthPoints, int damage, int level, int experience) 
            :base(name, maxHealthPoints, healthPoints, damage, level, experience)
        {
        }

        public void RageAttack()
        {
            double healthLossPercentage = 0.15;
            double increasedDamageMultiplier = 2;

            int oldDamage = this.Damage;
            int oldHealth = this.HealthPoints;

            int newHealth = (int)(oldHealth * (1 - healthLossPercentage));
            this.HealthPoints = newHealth;

            this.Damage = (int)(oldDamage * increasedDamageMultiplier);

            //this.Attack();
        }
    }
}
