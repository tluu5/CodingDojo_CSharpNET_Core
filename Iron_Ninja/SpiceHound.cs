using System;

namespace IronNinja
{
    class SpiceHound : Ninja
    {
        // provide override for IsFull (Full at 1200 Calories)
        public override bool IsFull
        {
            get { return calorieIntake > 1200; }
        }
        
        public override void Consume(IConsumable item)
        {
            // provide override for Consume
            if(IsFull)
            {
                Console.WriteLine("Too full, won't do it.");
                return;
            }
            int newCalories = (item.IsSpicy) ? item.Calories - 5 : item.Calories;
            calorieIntake += newCalories;
            ConsumptionHistory.Add(item);
            item.GetInfo();
        }
    }
}