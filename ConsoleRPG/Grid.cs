using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleRPG.Map
{
    public class Grid
    {
        private List<List<Tile>> Tiles;

        public Grid()
        {
            int size = 10;

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
                    ret += tile.Terrain;
                }
                ret += '\n';
            }

            return ret;
        }
    }
}
