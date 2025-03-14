using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private int _coinsQuantity;
    private Dictionary<string, ItemBase> _items;
    
    private void Start()
    {
        _items = new Dictionary<string, ItemBase>();
    }
    
    public void AddItem(ItemBase itemBase)
    {
        if (_items.ContainsKey(itemBase.GetName()))
        {
            _items[itemBase.GetName()].Count++;
        }
        else
        {
            _items[itemBase.GetName()] = itemBase;
        }
        
        Debug.Log("Item added: " + itemBase.ItemName);
        Debug.Log(itemBase.ItemName + " quantity: " + _items[itemBase.ItemName].Count);
    }
        
    public void IncreaseCoins(int amount)
    {
        _coinsQuantity += amount;
        Debug.Log("Coins quantity: " + _coinsQuantity);
    }
}
