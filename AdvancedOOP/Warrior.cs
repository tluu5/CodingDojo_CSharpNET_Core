using System;

namespace AdvancedOOP
{
    public class Warrior : Character
    {
        public Warrior(string n) : base(n, 6, 80, 9, 5) {}
        public override void DealDamage(Character target)
        {
            int amount = strength * -2;
            Console.WriteLine($"{this.name} strikes {target.name}, dealing {amount} damage!");
            target.ChangeHealth(amount);
            Console.WriteLine($"{target.name}'s health: {target.Health}");
        }
    }
}