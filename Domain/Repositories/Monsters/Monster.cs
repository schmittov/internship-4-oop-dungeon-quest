using Library.Domain.Repositories.Enums;
namespace Library.Domain.Repositories.Monsters
{
    public class Monster : Character
    {
        public int SpawningChance { get; set; }
        public int ExperienceWorth { get; set; }

        public Monster(string name, int maxHealthPoints, int healthPoints, int damage,int spawningChance,int experienceWorth)
        {
            Name = name;
            MaxHealthPoints = maxHealthPoints;
            HealthPoints = healthPoints;     
            Damage = damage;
            SpawningChance = spawningChance;
            ExperienceWorth = experienceWorth;
        }

        public override string MakeAttack(int choosenNumberFromTypeOfAttack)
        {
            switch (choosenNumberFromTypeOfAttack)
            {
                case 1:
                    return AttackType.direct.ToString();
                case 2:
                    return AttackType.side.ToString();
                default:
                    return AttackType.counter.ToString();
            }
        }
    }
}
