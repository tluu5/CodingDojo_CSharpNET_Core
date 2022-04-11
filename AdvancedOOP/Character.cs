using System;

namespace AdvancedOOP
{
    public abstract class Character
    {
        public string name;
        public int level;
        private int health;
        public int Health {get {return health;}}
        public int strength;
        public int intelligence;
        public Character(string n, int l, int h, int s, int i)
        {
            name = n;
            level = l;
            health = h;
            strength = s;
            intelligence = i;
        }
        public void showStats()
        {
            Console.WriteLine($"Name: {this.name}");
            Console.WriteLine($"Level: {this.level}");
            Console.WriteLine($"Health: {this.health}");
            Console.WriteLine($"Strength: {this.strength}");
            Console.WriteLine($"Intel: {this.intelligence}");
        }
        public virtual void DealDamage(Character target)
        {
            Console.WriteLine($"{this.name} attacked {target.name}, dealing 20 damage!");
            target.health -= 20;
            Console.WriteLine($"{target.name}'s health: {target.health}");
        }
        public void ChangeHealth(int amount)
        {
            this.health += amount;
        }
    }
}