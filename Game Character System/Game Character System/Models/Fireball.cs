using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Character_System.Models
{
    public class Fireball : Skill
    {
        public Fireball()
        {
            Name = "Fireball";
        }
        public override void UseSkill(Character user, Character target)
        {
            if (user.Mana >= 20)
            {
                user.Mana -= 20;
                Console.WriteLine($"{user.Name} {target.Name}-e {Name} atdı! (Mana -20)");
                target.Health -= 40;
            }
            else
            {
                Console.WriteLine($"{user.Name}-in {Name} ucun kifayet qeder manasi yoxdur!");
            }
        }
    }
}
