using Library.Domain.Repositories.Functions;
using Library.Domain.Repositories.Monsters;

int heroChooseValue,randomNumber;
string heroAttack,monsterAttack;
Console.WriteLine("Dobrodošli u Dungeons and Crawlesrs.");
Console.WriteLine("Za nastaviti pritisnite bilo koju tipku.");
Console.ReadKey();
do
{
    Console.Clear();
    Console.WriteLine("Birajte svog heroja:");
    Console.WriteLine("1. Gladijator");
    Console.WriteLine("2. Enchanter");
    Console.WriteLine("3. Marskman");
    if (int.TryParse(Console.ReadLine(), out heroChooseValue) && heroChooseValue >= 1 && heroChooseValue <= 3)
        break;
} while (true);
Console.Clear();

var hero = Functions.ChooseHero(heroChooseValue);
Console.WriteLine($"Odabrao si: {hero.Name}, HP: {hero.MaxHealthPoints}, Damage: {hero.Damage}");
Console.WriteLine("Za nastaviti kretati se kroz dungeone pritsini bilo koju tipku");
Console.ReadKey();

Console.Clear();
var monsters = Functions.GenerateRandomMonsters();

foreach (var monster in monsters)
{
    Console.WriteLine("Oprez! Naišao si na "+monster.Name+", bori s njim dok ga ne pobjediš.");
    do
    {
        Console.WriteLine($"Preostalo ti je: {hero.HealthPoints} HP-a, Damage: {hero.Damage} , Experience: {hero.Experience}, Level: {hero.Level}\n");
        
        Console.WriteLine("\nIspred tebe se nalazi "+monster.Name.ToString()+" i ima "+monster.HealthPoints.ToString()+" hp.");

        Random random = new();
        randomNumber = random.Next(1, 4);

        Console.WriteLine("1. direct\n2. side\n3. counter");
        Console.Write("Birajte vrstu napada: ");
        int x=int.Parse(Console.ReadLine());
        
        heroAttack=Functions.ChooseAttack(x);
        monsterAttack=Functions.ChooseAttack(randomNumber);


        if (Functions.AttackRound(heroAttack, monsterAttack, monster, hero).Item1)
            monster.HealthPoints -= Functions.AttackRound(heroAttack, monsterAttack, monster, hero).Item2;
        else
            hero.HealthPoints -= Functions.AttackRound(heroAttack, monsterAttack, monster, hero).Item2;
        
        Console.Clear();

    } while (hero.HealthPoints > 0 && monster.HealthPoints > 0);

    hero.Level+= Library.Domain.Repositories.Heroes.Hero.GetExperienceAndLevelUp(monster.ExperienceWorth, hero.Experience).Item2;
    if(Library.Domain.Repositories.Heroes.Hero.GetExperienceAndLevelUp(monster.ExperienceWorth, hero.Experience).Item3)
    {
        hero.HealthPoints = hero.MaxHealthPoints;
    }
    hero.Experience = Library.Domain.Repositories.Heroes.Hero.GetExperienceAndLevelUp(monster.ExperienceWorth, hero.Experience).Item1;

    if (!(hero.HealthPoints > 0))
        Console.WriteLine("Nažalost izgubili ste, pokušajte ponovno.");
}
Console.WriteLine("Čestitamo uspješno ste igru");
