using UnityEngine;

public class Key : ItemBase, ICollectible
{
    public Key()
    {
        ItemName = "Key";
    }
    public void Collect(IPlayer player)
    {
        player.GetInventory().AddItem(this);
        Destroy(gameObject);
    }
}