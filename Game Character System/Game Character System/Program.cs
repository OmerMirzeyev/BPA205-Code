using Game_Character_System.Models;
using System.Xml.Linq;

namespace Game_Character_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== OYUN BASLAYIR ===\n");

            Warrior garen = new Warrior("Garen");
            Mage lux = new Mage("Lux");
            Archer ashe = new Archer("Ashe");

            Console.WriteLine("\n--- CAN VE MANA ---");
            garen.ShowStatus();
            lux.ShowStatus();
            ashe.ShowStatus();

            lux.Skills.Add(new Fireball()); 
            garen.Skills.Add(new PowerStrike());
            ashe.Skills.Add(new Heal());
            Console.WriteLine("--- Normal Zerbeler ---");
            garen.Attack(lux); 
            ashe.Attack(garen); 
            lux.Attack(garen);
            Console.WriteLine("----Zerbeden Sonra Statuslar----");
            garen.ShowStatus();
            lux.ShowStatus();
            ashe.ShowStatus();
            Console.WriteLine("\n--- Xususi Skiller ---");
            lux.Skills[0].UseSkill(lux, garen);
            garen.Skills[0].UseSkill(garen, ashe);
            ashe.Skills[0].UseSkill(ashe, ashe);
            Console.WriteLine("\n--- CAN VE MANA ---");
            garen.ShowStatus();
            lux.ShowStatus();
            ashe.ShowStatus();
            Console.WriteLine("=== OYUN BITDI ===\n");
        }
    }
}
