using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace Game_Character_System.Models
{
    public abstract class Character
    {
        private string _name;
        private int _mana;
        private int _health;
        private int _level;
        public List<Skill> Skills = new List<Skill>();

        public string Name
        {
            get { return _name; }
            set 
            {
                if (value.Length == 0)
                {
                    Console.WriteLine("Name can not be empty");
                }
                else
                {
                    _name = value;
                }
            }
        }
        public int Mana
        {
            get { return _mana; }
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("Mana can not be negative");
                }
                else
                {
                    _mana = value;
                }
            }
        }
        public int Health 
        {
            get { return _health; }
            set
            {
                if( value < 0)
                {
                     Console.WriteLine("Health can not be negative");

                }
                else
                {
                    _health = value;
                }
            }
        }
        public int Level
        {
            get { return _level; }
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("Level can not be negative");
                }
                else
                {
                    _level = value;
                }
            }
        }
        public Character() 
        {

        }
        public virtual void Attack(Character target)
        {
            if (Health == 0)
            {
                Console.WriteLine($"{Name} is dead and cannot attack!");
            }
            Console.WriteLine($"{Name} performed a basic attack.");
        }

        public void AddSkill(Skill skill)
        {
            Skills.Add(skill);
        }

        public void UseSkill()
        {
            if (Health == 0)
            {
                Console.WriteLine($"{Name} is dead and cannot use a skill!");
            }
        }
        public void ShowStatus()
        {
            Console.WriteLine($"[{Name}] HP: {Health} | Mana: {Mana} | Lvl: {Level}");
        }
    }
}
