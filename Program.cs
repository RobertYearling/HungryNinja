using System;
using HungryNinja.Models;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Ninja One = new Ninja("One");
            Buffet Samurai = new Buffet("Samurai");
            Console.WriteLine(Samurai.Serve());
            One.Eat(Samurai.Serve());
            // while(!One.IsFull)
            // {
            //     One.Eat(Samurai.Serve());
            // }
        }
    }
}
