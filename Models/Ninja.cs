using System;
using System.Collections.Generic;

namespace HungryNinja.Models
{
    public class Ninja
    {
        public string Name;
        private int calorieIntake;
        // public int Menu(int cal)
        // {
        //     calorieIntake += cal;
        //     return cal;
        // }
        public int calorieAmount
        {
            get
            {
                return calorieIntake;
            }
        }

        public List<Food> FoodHistory;

        public void Eat(Food item)
        {
            this.calorieIntake += item.Calories;
            Console.WriteLine(item.Calories);
            this.FoodHistory.Add(item);
            Console.WriteLine("The Ninja is ready for battle");
        }

        public bool IsFull
        {
            get
            {
                return calorieIntake < 1200;
            }
        }

        public Ninja(string name)
        {
            Name = name;
            this.calorieIntake = 0;

            Console.WriteLine($"{Name} Has entered the Café");

        }
    }
}