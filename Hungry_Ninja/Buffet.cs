using System;
using System.Collections.Generic;

namespace FoodsAssignment
{
    class Buffet
    {
        public List<Food> Menu;
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Pizza", 800, false, false),
                new Food("Ice Cream", 950, true, false),
                new Food("Asparagus", 80, false, false),
                new Food("Burrito", 600, false, true),
                new Food("Crab Legs", 100, false, false),
            };
        }
        public Food Serve()
        {
            Random r = new Random();
            return Menu[r.Next(Menu.Count)];
        }

    }
}