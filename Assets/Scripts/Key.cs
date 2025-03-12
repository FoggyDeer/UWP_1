using UnityEngine;
using UnityEngine.EventSystems;

namespace DefaultNamespace
{
    public class Key : ItemBase, ICollectible
    {
        public void Collect(Player player)
        {
            player.GetInventory().AddItem(this);
        }
    }
}