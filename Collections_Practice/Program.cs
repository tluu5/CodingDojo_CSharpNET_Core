using System;
using System.Collections.Generic;

namespace Collections_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                
                ARRAYS

             */
            // Create an array to hold integer values 0 through 9
            int[] numbers = new int[10];
            for (var i = 0; i < numbers.Length; i++)
                numbers[i] = i;

            // Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string[] names = new string[]
            {
                "Tim", "Martin", "Nikki", "Sara"
            };

            // Create an array of length 10 that alternates between true and false values, starting with true
            bool[] boolies = new bool[10];
            for (var i = 0; i < boolies.Length; i++)
                boolies[i] = i % 2 == 0;

            /*
                
                LISTS

            */
            // Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
            List<string> flavors = new List<string>()
            {
                "Chocolate", "Strawberry", "Vanilla Bean", "Cookie Dough", "Dolce de Leche"
            };
            // Output the length of this list after building it
            Console.WriteLine($"Number of Flavors: {flavors.Count}");
            // Output the third flavor in the list, then remove this value
            Console.WriteLine($"Third Flavor: {flavors[2]}");
            flavors.RemoveAt(2);
            // Output the new length of the list (It should just be one fewer!)
            Console.WriteLine($"Number of Flavors: {flavors.Count}");
            /*

               DICTIONARIES

           */
            // Create a dictionary that will store both string keys as well as string values
            Dictionary<string, string> preferences = new Dictionary<string, string>();
            // For each name in the array of names you made previously, add it as a new key in this dictionary with value null
            foreach (var name in names)
                preferences.Add(name, null);
            // For each name key, select a random flavor from the flavor list above and store it as the value
            Random rand = new Random();
            foreach (var name in names)
                preferences[name] = (flavors[rand.Next(flavors.Count)]);
            // Loop through the dictionary and print out each user's name and their associated ice cream flavor
            foreach (var kp in preferences)
                Console.WriteLine($"{kp.Key} prefers {kp.Value}");
        }
    }
}
