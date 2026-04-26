using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Character_System.Models
{
    public abstract class Skill
    {
        public string Name { get; set; }
        public abstract void UseSkill(Character user, Character target); 
    }
}
