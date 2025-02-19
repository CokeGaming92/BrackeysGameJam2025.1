using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float rotationSpeed = 200f;
    private Rigidbody2D rb2D;
    private Vector2 movement; // Stores movement input

    float movementInputX, movementInputY; 

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Get player input
        movementInputX = Input.GetAxisRaw("Horizontal"); // A/D or Left/Right
        movementInputY = Input.GetAxisRaw("Vertical"); // W/S or Up/Down

        // Normalize movement so diagonal speed is consistent
        movement = movement.normalized;
    }

    private void FixedUpdate()
    {


        Vector2 moveDirection = new Vector2(movementInputX * moveSpeed, movementInputY * moveSpeed);
        // Apply movement using Rigidbody2D physics
        rb2D.velocity = moveDirection;
    }
}
