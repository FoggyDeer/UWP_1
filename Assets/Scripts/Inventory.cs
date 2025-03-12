using System;
using System.Collections.Generic;
using UnityEditor;

namespace DefaultNamespace
{
    public class Inventory
    {
        private int coinsQuantity = 0;
        private List<ItemBase> items;

        public void AddItem(ItemBase itemBase)
        {
            items.Add(itemBase);
        }
        
        public void IncreaseCoins(int amount)
        {
            coinsQuantity += amount;
        }
    }
}