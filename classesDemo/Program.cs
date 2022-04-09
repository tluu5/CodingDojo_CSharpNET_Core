using System;

namespace classesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Drink d1 = new Drink("Coffee", "brown", false, 95.5, 200);
            Console.WriteLine($"I am drinking {d1.name}");
            d1.name = "Tea";
            Console.WriteLine($"I am drinking {d1.name}");
            Drink d2 = new Drink("Coke", "brown", 32.6, 200);
            Drink d3 = new Drink("Sprite", "clear", 34.8, 120);
            Console.WriteLine(d2.isCarbonated);
            Drink d4 = new Drink();
            Console.WriteLine(d4.name);
            // Console.WriteLine(d1.calories);
            d1.addSugar(100);
            Console.WriteLine(d1.Calories);
        }
    }
}
