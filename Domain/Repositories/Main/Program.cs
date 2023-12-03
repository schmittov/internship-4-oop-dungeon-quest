using Library.Domain.Repositories.Heroes;
namespace Library.Domain.Repositories.Main
{
    public class ChooseCharacter
    {
        public static Hero ChooseHero()
        {
            Console.WriteLine("\nOdaberite heroja:");
            Console.WriteLine("1. Gladijator");
            Console.WriteLine("2. Enchanter");
            Console.WriteLine("3. Marksman");

            int choice;
            do
            {
                Console.Write("Unesite broj heroja (1-3): ");
            } while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3);

            switch (choice)
            {                            //name        maxhp    hp   damage  level  experience
                case 1:
                    return new Gladiator("Gladijator", 100, 100, 30, 0, 0);
                case 2:
                    return new Enchanter("Enchanter", 80, 80, 80, 0, 0, 0,true);
                case 3:
                    return new Marksman("Marksman", 90, 90, 50, 0, 0,0,0);
                default:
                    throw new InvalidOperationException("Nepoznat broj heroja.");
            }
        }
    }
}
