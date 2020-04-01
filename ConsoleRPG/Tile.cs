using ConsoleRPG.Items;

namespace ConsoleRPG.Map
{
    public class Tile
    {
        public Position Position;
        public char Representative;
        public TerrainTypes Terrain;

        public bool Walkable;
        public Collectable Item;

        //public Tile(Position p, char terrain, bool walkable)
        //{
        //    Position = p;
        //    Representative = terrain;
        //    Walkable = walkable;
        //    TerrainTypes Terrain = TerrainTypes.floor;
        //}

        public Tile(Position p, TerrainTypes t)
        {
            Position = p;
            Terrain = t;

            switch (Terrain)
            {
                case TerrainTypes.floor:
                    Representative = ' ';
                    Walkable = true;
                    break;
                case TerrainTypes.wall:
                    Representative = '█';
                    Walkable = false;
                    break;
                default:
                    Representative = ' ';
                    Walkable = true;
                    break;
            }
        }

        public void UpdateTile()
        {
            //this function updates tiles representative (if item is in place then its graphics should overwrite terrain)
            if (Item != null)
            {
                Representative = Item.Representative;
            }
            else
            {
                switch (Terrain)
                {
                    case TerrainTypes.floor:
                        Representative = ' ';
                        Walkable = true;
                        break;
                    case TerrainTypes.wall:
                        Representative = '█';
                        Walkable = false;
                        break;
                    default:
                        Representative = ' ';
                        Walkable = true;
                        break;
                }
            }
        }
    }

    public enum TerrainTypes
    {
        floor = 0,
        wall = 1
    }
}
