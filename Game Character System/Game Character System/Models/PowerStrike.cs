using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Character_System.Models
{
    public class PowerStrike : Skill
    {
            public PowerStrike()
            {
                Name = "Power Strike";
            }

            public override void UseSkill(Character user, Character target)
            {
                Console.WriteLine($"{user.Name} bütün gücü ile {target.Name}-e {Name} vurdu!");
                target.Health -= 50;
            }
        }
}
