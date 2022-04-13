namespace IronNinja
{
    class Drink : IConsumable
    {
        public string Name {get;set;}
        public int Calories {get;set;}
        public bool IsSpicy {get;set;}
        public bool IsSweet {get;set;}
        
        // Implement a GetInfo Method
        // Add a constructor method
        public Drink(string name, int calories, bool isSpicy)
        {
            Name = name;
            Calories = calories;
            IsSpicy = isSpicy;
            IsSweet = true;
        }
        public string GetInfo()
        {
            return $"{Name} (Tasty Drink!).  Calories: {Calories}.  Spicy?: {IsSpicy}, Sweet?: {IsSweet}";
        }
    }  
}