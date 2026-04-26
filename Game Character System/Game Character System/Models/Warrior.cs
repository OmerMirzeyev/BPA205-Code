using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Character_System.Models
{
    public class Warrior : Character 
    {
        public Warrior(string name)
        {
            Name = name;
            Health = 150;
            Mana = 20;
            Level = 1;
        }
        public override void Attack(Character target)
        {
            if (this.Health == 0)
            {
                Console.WriteLine($"Olu karakter ({this.Name})");
            }
            if (target.Health == 0)
            {
                Console.WriteLine($" {target.Name} onsuz da oludur.");
            }

            Console.WriteLine($"{Name} {target.Name}-e zerbe endirdi");
            target.Health -= 30;
        }
    }
}
