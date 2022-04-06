using System;
namespace Heroes
{
    class Ninja : Human
    {
        public Ninja(string name) : base(name, 3, 3, 175, 100) { }
        public override int Attack(Human target)
        {
            Random r = new Random();
            int dmg = 5 * Dexterity;
            if (r.Next(100) <= 20)
                dmg += 10;
            return base.Attack(target, dmg);
        }
        public void Steal(Human target)
        {
            health += base.Attack(target, 10);
        }
    }
}