using System;

namespace classesDemo
{
    public class Drink
    {
        public string name;
        public string color;
        public bool isCarbonated;
        public double temperature;
        private int calories;
        public int Calories {get {return calories;}}
        public double ounces;
        public Drink(string n, string c, bool isC, double t, int cal)
        {
            name = n;
            color = c;
            isCarbonated = isC;
            temperature = t;
            calories = cal;
        }
        public Drink(string n, string c, double t, int cal)
        {
            name = n;
            color = c;
            isCarbonated = true;
            temperature = t;
            calories = cal;
        }
        public Drink()
        {
            name = "Water";
            color = "clear";
            isCarbonated = false;
            temperature = 40.2;
            calories = 0;
        }
        public void addSugar(int amount)
        {
            this.calories+=amount;
            Console.WriteLine($"Sugar was added and now your calories count is {this.calories}");
        }
    }
}