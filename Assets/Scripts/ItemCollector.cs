using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(PlayerBase))]
public class ItemCollector : MonoBehaviour
{
    private PlayerBase _playerBase;
    
    private void Start()
    {
        _playerBase = GetComponent<PlayerBase>();
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out ICollectible collectible))
        {
            collectible.Collect(_playerBase);
        }
    }
}
