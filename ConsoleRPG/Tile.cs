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
    }
}
