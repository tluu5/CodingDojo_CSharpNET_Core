using System;

namespace IronNinja
{
    class SweetTooth : Ninja
    {
        // provide override for IsFull (Full at 1500 Calories)
        public override bool IsFull
        {
            get { return calorieIntake > 1500; }
        }
        public override void Consume(IConsumable item)
        {
            // provide override for Consume
            if(IsFull)
            {
                Console.WriteLine("Too full, won't do it.");
                return;
            }
            int newCalories = (item.IsSweet) ? item.Calories + 10 : item.Calories;
            calorieIntake += newCalories;
            ConsumptionHistory.Add(item);
            item.GetInfo();
        }
    }
}