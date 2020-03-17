using System;

namespace ConsoleRPG.InputHandling
{
    public class InputHandler
    {
        public string CurrentKey { get; set; }
        public string PreviousKey { get; set; }

        public InputHandler()
        {
            CurrentKey = "";
            PreviousKey = "";
        }

        public void GetKey()
        {
            PreviousKey = CurrentKey;
            CurrentKey = Console.ReadKey().Key.ToString();
        }

        //For testing purposes
        public void GetKey(ConsoleKey key)
        {
            PreviousKey = CurrentKey;
            CurrentKey = key.ToString();
        }
    }
}
