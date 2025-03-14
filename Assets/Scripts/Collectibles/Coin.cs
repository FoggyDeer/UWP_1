using UnityEngine;

public class Coin : ItemBase, ICollectible
{
    public Coin()
    {
        ItemName = "Coin";
    }
    
    public void Collect(IPlayer playerBase)
    {
        playerBase.GetInventory().IncreaseCoins(1);
        Destroy(gameObject);
    }
}