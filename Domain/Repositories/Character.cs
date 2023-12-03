namespace Library.Domain.Repositories
{
    public class Character
    {
        public string Name { get; set; }
        public int HealthPoints {  get; set; }
        public int Damage { get; set; }


        public Character(string name, int healthPoints, int damage)
        {
            Name = name;
            HealthPoints = healthPoints;    
            Damage = damage;
        }

        public static string ChooseAttack(int x)
        {
            switch (x)
            {
                case 0:
                    return "Direct";
                case 1:
                    return "Side";
                default:
                    return "Counter";
            }
        }
    }
}
