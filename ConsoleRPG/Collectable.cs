using System;
using ConsoleRPG.PlayerCharacter;

namespace ConsoleRPG.Items
{
    public class Collectable
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public char Representable { get; set; }

        public void Collect(Player p)
        {
            Console.WriteLine("You found " + Amount.ToString() + " of " + Name + ".");
        }
    }
}
