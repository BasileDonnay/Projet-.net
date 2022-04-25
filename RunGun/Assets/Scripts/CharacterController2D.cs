using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController2D : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 50f;
    [SerializeField] private int jumpForce = 250;
    public string horizontal = "Horizontal";
    public string vertical = "Vertical";

    private float horizontalMove = 0f;
    public Transform groundCheckLeft;
    public Transform groundCheckRight;
    private bool isGrounded = true;
    public Rigidbody2D rb;
    public bool PS4Control = false;

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalMove = Input.GetAxisRaw(horizontal) / movementSpeed;
        transform.position += new Vector3(horizontalMove, 0, 0);
    }

    void Update()
    {
        if(PS4Control==true){
            // déplacement 
        transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * 3 * Time.deltaTime);
        transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * 3 * Time.deltaTime);
        
        //Saut

        if(Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 200); 
        }


        
        }else{

        isGrounded = Physics2D.OverlapArea(groundCheckLeft.position, groundCheckRight.position);

        if (Input.GetButtonDown(vertical) && Input.GetAxisRaw(vertical) == 1 && isGrounded)
        {
            rb.AddForce(new Vector2(0f, jumpForce));
        }
    }

    }
}
