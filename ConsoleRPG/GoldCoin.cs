using ConsoleRPG.PlayerCharacter;

namespace ConsoleRPG.Items
{
    public class GoldCoin : Collectable
    {
        public GoldCoin(int amount)
        {
            Amount = amount;
            Name = "Gold Coin";
            Representable = 'o';
        }

        public new void Collect(Player p)
        {
            p.Gold += Amount;
            base.Collect(p);
        }
    }
}
