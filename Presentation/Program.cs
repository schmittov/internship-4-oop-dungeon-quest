using Library.Domain.Repositories.Functions;
using Library.Domain.Repositories.Heroes;
using Library.Domain.Repositories.Monsters;

int heroChooseValue,randomNumber,x=4,counter=0;
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
Console.WriteLine($"Odabrali ste: {hero.Name}, Maksimalan HP mu je : {hero.MaxHealthPoints}, Zadaje damage : {hero.Damage}");
Console.WriteLine("Za nastaviti kretati se kroz dungeone pritsini bilo koju tipku");
Console.ReadKey();

Console.Clear();
var monsters = Functions.GenerateRandomMonsters();

foreach (var monster in monsters)
{
    Console.WriteLine("Oprez! Naišao si na "+monster.Name+", bori s njim dok ga ne pobjediš.");
    do
    {
        Random random = new();
        randomNumber = random.Next(1, 4);

        do
        {
            Console.WriteLine($"Status tvog heroja: {hero.HealthPoints} HP-a, Damage: {hero.Damage} , Experience: {hero.Experience}, Level: {hero.Level}\n");
            Console.WriteLine("Preostalo je još " + (10 - counter) + " čudovišta");
            Console.WriteLine("\nIspred tebe se nalazi " + monster.Name.ToString() + " i ima " + monster.HealthPoints.ToString() + " hp.");
            Console.WriteLine("1. direct\n2. side\n3. counter");
            Console.Write("Birajte vrstu napada: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out x))
                if (x >= 1 && x <= 3)
                    break;
                else
                    Console.Clear();
        } while (true);

        heroAttack = hero.MakeAttack(x);
        monsterAttack=monster.MakeAttack(randomNumber);

        

        if (Functions.AttackRound(heroAttack, monsterAttack, monster, hero).Item1)
            monster.HealthPoints -= Functions.AttackRound(heroAttack, monsterAttack, monster, hero).Item2;
        else
            hero.HealthPoints -= Functions.AttackRound(heroAttack, monsterAttack, monster, hero).Item2;
        
        
        Console.Clear();

    } while (hero.HealthPoints > 0 && monster.HealthPoints > 0);
    counter++;

    hero.HealthPoints += (int)(hero.MaxHealthPoints*0.25);
    hero.Level+= Hero.GetExperienceAndLevelUp(monster.ExperienceWorth, hero.Experience).Item2;
    if(Hero.GetExperienceAndLevelUp(monster.ExperienceWorth, hero.Experience).Item3)
        hero.HealthPoints = hero.MaxHealthPoints;
    
    hero.Experience = Hero.GetExperienceAndLevelUp(monster.ExperienceWorth, hero.Experience).Item1;
    hero.HealthPoints = Hero.CheckHealthStatus(hero.HealthPoints, hero.MaxHealthPoints);


    if (!(hero.HealthPoints >= 0))
        Console.WriteLine("Nažalost izgubili ste, pokušajte ponovno.");
}
Console.WriteLine("Čestitamo uspješno ste došli do kraja dungeona, osvojili ste keks.");
