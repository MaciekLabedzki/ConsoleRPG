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
        public int Gold { get; set; }

        public Player(int x, int y)
        {
            Position = new Position(x, y);
            Representative = 'P';
            Gold = 0;
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
