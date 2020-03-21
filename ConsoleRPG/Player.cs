using System;
using System.Collections.Generic;
using System.Text;
using ConsoleRPG.Map;

namespace ConsoleRPG.PlayerCharacter
{
    public class Player
    {
        public Position Position;
        public char Representative;

        public Player(int x, int y)
        {
            Position = new Position(x, y);
            Representative = 'P';
        }

        public string ShowPosition()
        {
            return "Player position" + '\n' + 
                "X: " + Position.X.ToString() + "- Y:" + Position.Y.ToString();
        }
    }

    public enum Directions
    {
        Left,
        Right,
        Up,
        Down
    }
}
