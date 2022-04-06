using System;
namespace Heroes
{
    class Samurai : Human
    {
        // Samurai should have a default health of 200	
        public Samurai(string name) : base(name, 3, 3, 3, 200)
        {
        }
        // Samurai should have a method called death_blow, which when invoked should attack an object and decreases its health to 0 if it has less than 50 health	
        public override int Attack(Human target)
        {
            int remainingHealth = Attack(target);
            if (remainingHealth < 50)
            {
                target.Health = 0;
                Console.WriteLine($"{target.Name} IS FINISHED BY THE DEATH BLOW!");
            }
            return remainingHealth;
        }
        // Samurai should have a method called meditate, which when invoked, heals the Samurai back to full health	
        public void Meditate()
        {
            health = 200;
        }
    }
}