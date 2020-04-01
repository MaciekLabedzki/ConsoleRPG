using System;
using ConsoleRPG.PlayerCharacter;

namespace ConsoleRPG.Items
{
    public class Collectable
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public char Representative { get; set; }

        public Collectable()
        {
            Name = "";
        }

        public virtual void Collect(Player p)
        {
            Console.WriteLine("You found " + Amount.ToString() + " of " + Name + ".");
        }
    }
}
