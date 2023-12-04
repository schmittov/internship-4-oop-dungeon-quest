using Library.Domain.Repositories.Interfaces;

namespace Library.Domain.Repositories
{
    public abstract class Character : ICharacterActions
    {
        public string Name { get; set; }
        public int MaxHealthPoints { get; set; }
        public int HealthPoints { get; set; }
        public int Damage { get; set; }

        public abstract void MakeAttack();
    }
}
