using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController2D : MonoBehaviour
{
    [SerializeField] private float x_addition = 0.01f;
    [SerializeField] private string left = "q";
    [SerializeField] private string right = "d";
    [SerializeField] private string up = "z";
    [SerializeField] private int jumpForce = 200;

    public Transform groundCheckLeft;
    public Transform groundCheckRight;
    private bool isGrounded = true;
    private bool jumpCooldown = false;
    public int jCConst = 50;
    private int jCCounter = 0;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        jCCounter = jCConst;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(right))
        {
            transform.position = transform.position + new Vector3(x_addition, 0, 0);
        }
        if (Input.GetKey(left))
        {
            transform.position = transform.position - new Vector3(x_addition, 0, 0);
        }

        isGrounded = Physics2D.OverlapArea(groundCheckLeft.position, groundCheckRight.position);
        updateJumpCooldown();

        if (Input.GetKey(up) && isGrounded && jumpCooldown)
        {
            rb.AddForce(new Vector2(0f, jumpForce));
            jumpCooldown = false;
        }
    }

    private void updateJumpCooldown()
    {
        if (jumpCooldown == false)
        {
            jCCounter--;
            if (jCCounter <= 0)
            {
                jumpCooldown = true;
                jCCounter = jCConst;
            }
        }
    }
}
