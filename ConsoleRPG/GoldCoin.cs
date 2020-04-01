using ConsoleRPG.PlayerCharacter;

namespace ConsoleRPG.Items
{
    public class GoldCoin : Collectable
    {
        public GoldCoin(int amount = 1)
        {
            Amount = amount;
            Name = "Gold Coin";
            Representative = 'o';
        }

        public override void Collect(Player p)
        {
            p.Gold += Amount;
            base.Collect(p);
        }
    }
}
