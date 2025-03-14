using UnityEngine;

[RequireComponent(typeof(Inventory))]
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerBase : MonoBehaviour, IPlayer
{
    private int _health = 50;
    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        Debug.Log("Player health: " + _health);
    }
        
    private void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        _rb.velocity = new Vector2(moveHorizontal*10, _rb.velocity.y);
    }

    public void Heal()
    {
        _health = 100;
        Debug.Log("Player health: " + _health);
    }

    public Inventory GetInventory()
    {
        return GetComponent<Inventory>();
    }
}