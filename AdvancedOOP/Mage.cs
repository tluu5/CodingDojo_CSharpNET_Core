using System;

namespace AdvancedOOP
{
    public class Mage : Character, ICastMagic
    {
        public int mana {get;set;}
        // public int mana;
        public Mage(string n, int m) : base(n, 7, 65, 6, 9)
        {
            mana = 200;
        }
        public override void DealDamage(Character target)
        {
            int amount = intelligence * -2;
            Console.WriteLine($"{this.name} strikes {target.name} with a magic bolt, dealing {amount} damage!");
            target.ChangeHealth(amount);
            this.mana -= 10;
            Console.WriteLine($"{target.name}'s health: {target.Health}");
            Console.WriteLine($"{this.mana}'s mana: {this.mana}");
        }
        public void castSpell()
        {
            mana -= 10;
            Console.WriteLine("You cast a spell!");
        }
    }
}