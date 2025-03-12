using UnityEngine;

namespace DefaultNamespace
{
    public class Coin : ItemBase, ICollectible
    {
        public void Collect(Player player)
        {
            player.GetInventory().IncreaseCoins(1);
        }
    }
}