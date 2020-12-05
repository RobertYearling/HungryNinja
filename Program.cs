using System;

namespace HungryNinja
{
    class Program
    {
        class Food
        {
            public string Name;
            public int Calories;
            public bool IsSpicy;
            public bool IsSweet;
            public Food(string name, int cal, bool spicy, bool sweet)
            {
                Name = name;
                Calories = cal;
                IsSpicy = spicy;
                IsSweet = sweet;
            }

        }

        class Buffet
        {
            public List<Food> Menu;

            public Buffet()
            {
                Menu = new List<Food>()
                {
                    new Food("Name", 300, false, false)
                };
            }
            public Food Serve()
            {

            }

        }

        class Ninja
        {
            private int calorieIntake;
            public List<Food> FoodHistory;

            public Food(int cal)
            {
                Calories = 0;
            }

            public void Eat(Food item)
            {
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
