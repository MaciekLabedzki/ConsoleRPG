using System;
using System.Collections.Generic;
using System.Text;
using ConsoleRPG.Map;

namespace ConsoleRPG.PlayerCharacter
{
    public class Player
    {
        public Position position;
        public char Representative;

        public Player()
        {
            position = new Position(0, 0);
            Representative = 'P';
        }
    }
}
