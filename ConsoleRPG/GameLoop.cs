using ConsoleRPG.Map;
using ConsoleRPG.PlayerCharacter;
using System;

namespace ConsoleRPG.Game
{
    public class GameLoop
    {
        public Player Player;
        public Grid Grid;

        public GameLoop()
        {
            Player = new Player(1, 1);
            Grid = new Grid(Player);
            ConsoleKey choice;

            while (true)
            {
                //kod do wyświetlenia samego grida
                Console.Clear();
                Console.WriteLine("It should show 10x10 grid with a player on 0x0" + '\n' + "Press Escape to exit." + '\n' + '\n');
                Console.WriteLine(Grid.GridToString());
                choice = Console.ReadKey(false).Key;

                switch (choice)
                {
                    case ConsoleKey.LeftArrow:
                        Player.Position.X--;
                        break;
                    case ConsoleKey.RightArrow:
                        Player.Position.X++;
                        break;
                    case ConsoleKey.UpArrow:
                        Player.Position.Y--;
                        break;
                    case ConsoleKey.DownArrow:
                        Player.Position.Y++;
                        break;
                    case ConsoleKey.Escape:
                        return;
                    default:
                        break;

                }
            }
        }
    }
}
