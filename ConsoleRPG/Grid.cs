using ConsoleRPG.PlayerCharacter;
using System;
using System.Collections.Generic;

//(char) 219

namespace ConsoleRPG.Map
{
    public class Grid
    {
        public List<List<Tile>> Tiles;
        public Player player;
        public int size;

        public Grid(Player p)
        {
            player = p;
            size = 15;

            Tiles = new List<List<Tile>>();
            for (int y = 0; y < size; y++)
            {
                Tiles.Add(new List<Tile>());
                for (int x = 0; x < size; x++)
                {
                    Tiles[y].Add(RandomTile(new Position(x,y))); //add random
                }
            }
        }

        public Tile RandomTile(Position p)
        { 
            int tmp = Enum.GetValues(typeof(TerrainTypes)).Length;
            return new Tile(p, (TerrainTypes)new Random().Next(0,(int)(tmp*5)));
        }

        public bool CheckNeighborWalkability(Directions direction)
        {
            int x = 0, y = 0;

            switch (direction)
            {
                case Directions.Left:
                    x--;
                    break;
                case Directions.Right:
                    x++;
                    break;
                case Directions.Up:
                    y--;
                    break;
                case Directions.Down:
                    y++;
                    break;
            }

            return Tiles[player.Position.Y + y][player.Position.X + x].Walkable;
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
