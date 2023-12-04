namespace Library.Domain.Repositories.Heroes
{
    public class Gladiator : Hero
    {

        public Gladiator(string name, int maxHealthPoints, int healthPoints, int damage, int level, int experience) 
            :base(name, maxHealthPoints, healthPoints, damage, level, experience)
        {
        }

        public static (int,int,bool) RageAttack(int gladiatorHealth, int gladiatorDamage)
        {
            int chooseNumber;
            Console.WriteLine("Želite li iskoristiti rage attack");
            do
            {
                Console.WriteLine("1. Da");
                Console.WriteLine("2. Ne");
                string input = Console.ReadLine();

                if (int.TryParse(input, out chooseNumber))
                    if (chooseNumber == 1 || chooseNumber == 2)
                    {
                        if (chooseNumber == 1)
                            return ((int)(gladiatorHealth * 0.85), gladiatorDamage, true);
                        else
                            return (gladiatorHealth, gladiatorDamage, false);
                    }

            } while (true);

            
        }
    }
}
