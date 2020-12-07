using System;
using System.Collections.Generic;

namespace HungryNinja.Models
{
    public class Buffet
    {
        List<Food> MenuItem;

        public Buffet(string name)
        {
            MenuItem = new List<Food>()
            {
                new Food("Grasshopper", 150, false, true),
                new Food("Cookie Dough", 370, false, true),
                new Food("Carrots", 100, false, false),
                new Food("Mandarin Orange Chicken", 190, true, true),
                new Food("Kung Pao", 240, true, true),
                new Food("Sweet and Sour Chicken", 348, false, true),
                new Food("Beef Chop Suey", 400, false, false),
            };
        }
        public Food Serve()
        {
            // if(target.IsFull)
            // {
            //     Console.WriteLine("You have one stuffed Ninja!!!, No more food for you.");
            // }

            Random rand = new Random();
            Console.WriteLine(MenuItem[rand.Next(0,MenuItem.Count)].Name);
            return MenuItem[rand.Next(0,MenuItem.Count)];

            // Console.WriteLine($"{target.Name} ate {cal.Name} and it was spicy {cal.IsSpicy}, it was sweet {cal.IsSweet}!");
            // Console.WriteLine($"{Name} ate {cal.Name} and it was {Buffet.sweet}!");

            // target.Menu(cal.Calories);
        }
    }
}