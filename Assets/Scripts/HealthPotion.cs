using UnityEngine;

namespace DefaultNamespace
{
    public class HealthPotion : ItemBase, ICollectible
    {
        public void Collect(Player player)
        {
            player.Heal();
        }
    }
}