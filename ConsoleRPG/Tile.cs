namespace ConsoleRPG.Map
{
    public class Tile
    {
        public Position Position;
        public char Terrain;

        public bool Walkable;

        public Tile(Position p, char terrain, bool walkable)
        {
            Position = p;
            Terrain = terrain;
            Walkable = walkable;
        }

        public Tile(Position p, TerrainTypes t)
        {
            Position = p;
            switch (t)
            {
                case TerrainTypes.floor:
                    Terrain = ' ';
                    Walkable = true;
                    break;
                case TerrainTypes.wall:
                    Terrain = '█';
                    Walkable = false;
                    break;
                default:
                    Terrain = ' ';
                    Walkable = true;
                    break;
            }
        }
    }

    public enum TerrainTypes
    {
        floor = 0,
        wall = 1
    }
}
