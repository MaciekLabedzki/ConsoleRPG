using ConsoleRPG.PlayerCharacter;
using System.Collections.Generic;

namespace ConsoleRPG.Map
{
    public class Grid
    {
        public List<List<Tile>> Tiles;
        public Player player;

        public Grid(Player p)
        {
            int size = 10;
            player = p;

            Tiles = new List<List<Tile>>();
            for (int y = 0; y < size; y++)
            {
                Tiles.Add(new List<Tile>());
                for (int x = 0; x < size; x++)
                {
                    Tiles[y].Add(new Tile(new Position(x, y), '.', true));
                }
            }
        }

        public string GridToString()
        {
            string ret = "";

            foreach(List<Tile> row in Tiles)
            {
                foreach(Tile tile in row)
                {
                    char tmp;
                    if ((player.Position.X == tile.Position.X) && (player.Position.Y == tile.Position.Y))
                        tmp = player.Representative;
                    else
                        tmp = tile.Terrain;

                    ret += tmp;
                }
                ret += '\n';
            }

            return ret;
        }
    }
}
