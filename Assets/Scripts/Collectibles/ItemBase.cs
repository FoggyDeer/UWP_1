using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class ItemBase : MonoBehaviour
{
    public string ItemName { get; set; }
    public int Count { get; set; } = 1;

    public string GetName()
    {
        return ItemName;
    }
}