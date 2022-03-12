using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController2D : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 50f;
    [SerializeField] private int jumpForce = 250;

    private float horizontalMove = 0f;
    public Transform groundCheckLeft;
    public Transform groundCheckRight;
    private bool isGrounded = true;
    public Rigidbody2D rb;

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") / movementSpeed;
        transform.position += new Vector3(horizontalMove, 0, 0);
    }

    void Update()
    {
        isGrounded = Physics2D.OverlapArea(groundCheckLeft.position, groundCheckRight.position);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(new Vector2(0f, jumpForce));
        }
    }

    
}
