using UnityEngine;

public class HealthPotion : ItemBase, ICollectible
{
    public HealthPotion()
    {
        ItemName = "Health Potion";
    }
    
    public void Collect(IPlayer player)
    {
        player.Heal();
        Destroy(gameObject);
    }
}