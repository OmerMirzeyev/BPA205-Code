using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Character_System.Models
{
    public class Mage : Character
    {
        public Mage(string name)
        {
            Name = name;
            Health = 80;
            Mana = 100;
            Level = 1;
        }

        public override void Attack(Character target)
        {
            if (this.Health == 0)
            {
                Console.WriteLine($"Olu ({this.Name}) attack ede bilmez!");
            }
            if (target.Health == 0)
            {
                Console.WriteLine($"{target.Name} onsuz da oludur");
            }

            if (this.Mana >= 10)
            {
                this.Mana -= 10;
                Console.WriteLine($"{Name} mana istifade ederek {target.Name}e sehrli attack etdi (Mana -10)");
                target.Health -= 25;
            }
            else
            {
                Console.WriteLine($"{Name} attack etmey ucun kifayet qeder mana yoxdu");
            }
        }
    }
}
