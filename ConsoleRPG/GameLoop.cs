using ConsoleRPG.Items;
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
            Grid = new Grid(Player, 12); //generate grid with 12 gold coins
            ConsoleKey choice;

            while (true)
            {
                //wyświetlanie itemków
                Grid.UpdateTiles();

                //kod do wyświetlenia samego grida
                Console.Clear();
                //Console.WriteLine("It should show 10x10 grid with a player on 0x0" + '\n' + "Press Escape to exit." + '\n' + '\n');
                Console.WriteLine(Grid.GridToString());
                Console.WriteLine(Player.ShowPlayer());
                choice = Console.ReadKey(false).Key;

                switch (choice)
                {
                    case ConsoleKey.LeftArrow:
                        if(Player.Position.X!=0 && Grid.CheckNeighborWalkability(Directions.Left))
                            Player.Position.X--;
                        break;
                    case ConsoleKey.RightArrow:
                        if (Player.Position.X != Grid.size - 1 && Grid.CheckNeighborWalkability(Directions.Right))
                            Player.Position.X++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (Player.Position.Y != 0 && Grid.CheckNeighborWalkability(Directions.Up))
                            Player.Position.Y--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (Player.Position.Y != Grid.size - 1 && Grid.CheckNeighborWalkability(Directions.Down))
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
