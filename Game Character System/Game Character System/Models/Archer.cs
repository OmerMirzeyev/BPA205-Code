using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Character_System.Models
{
    public class Archer : Character
    {
        public Archer(string name)
        {
            Name = name;
            Health = 100;
            Mana = 40;
            Level = 1;
        }

        public override void Attack(Character target)
        {
            if (this.Health == 0)
            {
                Console.WriteLine($"Olu karakter ({this.Name}) attack ede bilmez!");
            }
            if (target.Health == 0)
            {
                Console.WriteLine($"{target.Name} onsuz da oludur.");
            }

            Console.WriteLine($"{Name} {target.Name}e uzaqdan ox atdı!");
            target.Health -= 20;
        }
    }
}
