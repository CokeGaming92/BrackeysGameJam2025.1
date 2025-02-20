using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyMoverFourDirection : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float speed;

    private Vector2 moveInput;

    void Start()
    {
        if (rb == null)
        {
            rb = GetComponent<Rigidbody2D>();

            if (rb == null)
                Debug.Log("Mover script unable to find Rigidbody2D!");
        }
    }

    void FixedUpdate()
    {
        moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
        rb.MovePosition(rb.position + moveInput * speed * Time.fixedDeltaTime);
    }
}

