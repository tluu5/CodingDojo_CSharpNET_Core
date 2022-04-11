using System;
using System.Collections.Generic;

namespace AdvancedOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Character myCharacter = new Character ("InertNameHere", 5, 50, 8, 5);
            // Character chara = new Character ("Inert2", 7, 70, 7, 2);
            // Character charb = new Character ("Inert3", 5, 30, 4, 10);
            // Console.WriteLine(myCharacter.name);
            Character w1 = new Warrior ("WarriorName");
            Warrior w2= new Warrior ("WarriorName");
            Sorceror s1 = new Sorceror("Dr. Strange", 200);
            Mage m1 = new Mage("Dr. Mage", 210);

            List<Warrior> allWarriors = new List<Warrior>();
            allWarriors.Add((Warrior)w1);

            List<Character> allCharacters = new List<Character>();
            allCharacters.Add(w1);
            allCharacters.Add(w2);
            allCharacters.Add(s1);
            allCharacters.Add(m1);
            w1.showStats();
            s1.showStats();
            w1.DealDamage(s1);
            s1.DealDamage(w1);
            List<ICastMagic> allMagicUsers = new List<ICastMagic>();
            List<Character> Normies = new List<Character>();
            foreach(Character c in allCharacters)
            {
                if(c is ICastMagic)
                {
                    allMagicUsers.Add((ICastMagic)c);
                } else {
                    Normies.Add(c);
                }
            }
            foreach(Character c in allMagicUsers)
            {
                Console.WriteLine(c.name);
            }
        }
    }
}
