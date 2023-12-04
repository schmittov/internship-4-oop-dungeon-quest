using Library.Domain.Repositories.Enums;
using Library.Domain.Repositories.Heroes;
using Library.Domain.Repositories.Monsters;
namespace Library.Domain.Repositories.Functions
{
    public class Functions
    {
        public static List<Monster> GenerateRandomMonsters()
        {
            List<Monster> monsters = new();
            Random random = new();

            for (int i = 0; i < 10; i++)
            {
                int monsterType = random.Next(1, 4);
                Monster monster;
                switch (monsterType)
                {
                    case 1:
                        monster = new Goblin("Goblin", random.Next(20, 40), random.Next(5, 15), random.Next(5, 10), 60, 30);
                        break;
                    case 2:
                        monster = new Brute("Brute", random.Next(70, 100), random.Next(15, 25), random.Next(10, 20), 30, 70, 1);
                        break;
                    case 3:
                        monster = new Witch("Witch", random.Next(40, 60), random.Next(25, 35), random.Next(8, 15), 10, 100);
                        break;
                    default:
                        throw new InvalidOperationException("Nepoznata vrsta čudovišta.");
                }

                monsters.Add(monster);
            }

            return monsters;
        }

        public static Hero ChooseHero(int heroOption)
        {
            Gladiator gladiator = new("Gladijator", maxHealthPoints: 100, healthPoints: 100, damage: 20, level: 1, experience: 0);
            Enchanter enchanter = new("Enchanter", maxHealthPoints: 30, healthPoints: 30, damage: 80, level: 1, experience: 0, 0, true);
            Marksman marksman = new("Marksman", maxHealthPoints: 50, healthPoints: 50, damage: 50, level: 1, experience: 0, 0, 0);


            return heroOption switch
            {
                1 => gladiator,
                2 => enchanter,
                _ => marksman,
            };
        }
        public static string ChooseAttack(int choosenNumberFromTypeOfAttack)
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
        public static (bool, int) AttackRound(string playerAttack, string monsterAttack, Monster monster, Hero hero)
        {
            if(playerAttack==monsterAttack)
                return (false,0);
            switch (playerAttack)
            {
                case "direct":
                    if(monsterAttack=="side")
                        return (true,hero.Damage);
                    else
                        return (false,monster.Damage);
                case "side":
                    if(monsterAttack=="counter")
                        return (true, hero.Damage);
                    else
                        return (false, monster.Damage);
                default:
                    if (monsterAttack == "counter")
                        return (true, hero.Damage);
                    else
                        return (false, monster.Damage);
            }
        }
        public static int TakeDamage(bool isVictory, int damage)
        {
            if (isVictory)
            {
                return (damage);
            }
            else
            {
                return (-damage);
            }
        }

        public static string TypeOfAttacks()
        {
            return null;
        }
    }
}
