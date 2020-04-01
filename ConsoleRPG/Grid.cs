using ConsoleRPG.Items;
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

        public Grid(Player p, int amount)
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

            GenerateCollectable(amount);
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

        public void GenerateCollectable(int amount)
        {
            int i = 0;

            while ( i<amount )
            {
                Random rand = new Random();
                int x = rand.Next(0, size);
                int y = rand.Next(0, size);
                
                if (Tiles[y][x].Walkable)
                {
                    Tiles[y][x].Item = new GoldCoin(); ///CHANGE IT ON GENERAL COLLECTABLE!
                    Console.WriteLine(x.ToString() + "." + y.ToString());
                    Console.ReadKey(false);
                    Console.WriteLine(Tiles[y][x].Item.Representative);
                    Console.WriteLine(Tiles[y][x].Item.Name);
                }
                i++;
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
                        tmp = tile.Representative;

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

        public void UpdateTiles()
        {
            //player is updated in gridtostring()
            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    Tile tmp = Tiles[y][x];

                    //check if player get any collectables
                    if ((player.Position.X == x && player.Position.Y == y) && tmp.Item != null)
                    {
                        tmp.Item.Collect(player);
                        tmp.Item = null;
                    }
                    tmp.UpdateTile();
                }
            }
        }
    }
}
