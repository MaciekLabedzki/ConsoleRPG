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

            ret += ShowTopBottmFrame();

            foreach (List<Tile> row in Tiles)
            {
                //left frame
                ret += "|";

                //fill
                foreach(Tile tile in row)
                {
                    char tmp;
                    if ((player.Position.X == tile.Position.X) && (player.Position.Y == tile.Position.Y))
                        tmp = player.Representative;
                    else
                        tmp = tile.Terrain;

                    ret += tmp;
                }

                //right frame
                ret += "|"+'\n';
            }

            ret += ShowTopBottmFrame();

            return ret;
        }

        private string ShowTopBottmFrame()
        {
            string ret = "";

            //top frame
            for (int i = 0; i < Tiles.Count + 2; i++)
            {
                ret += "-";
            }
            ret += '\n';

            return ret;
        }
    }
}
