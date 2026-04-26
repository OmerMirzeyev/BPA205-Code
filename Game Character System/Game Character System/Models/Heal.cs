using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Character_System.Models
{
    public class Heal : Skill
    {
        public Heal()
        {
            Name = "Heal";
        }

        public override void UseSkill(Character user, Character target)
        {
            if (user.Mana >= 15)
            {
                user.Mana -= 15;
                user.Health += 30;
                Console.WriteLine($"{user.Name} {Name} istifade etdi və 30 Can qazandi (Mana -15)");
            }
            else
            {
                Console.WriteLine($"{user.Name}-in {Name} üçün kifayet qeder manasi yoxdur!");
            }
        }
    }
}
