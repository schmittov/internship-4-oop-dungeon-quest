using System;
using System.Collections.Generic;
namespace Library.Domain.Repositories.Heroes
{
    public class Enchanter : Hero
    {
        public int Mana {  get; set; } 
        public bool ExtraLife {  get; set; }
        public Enchanter(string name, int maxHealthPoints, int healthPoints, int damage, int level, int experience,int mana,bool extraLife) 
            :base(name, maxHealthPoints, healthPoints, damage, level, experience)
        {
            Mana = mana;
            ExtraLife = extraLife;
        }
    }
}
