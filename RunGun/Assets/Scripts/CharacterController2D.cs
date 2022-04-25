using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

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
    GameObject player = null;

    // Update is called once per frame


 void Start()
   {

   for (int i =0; i< Gamepad.all.Count; i++)
{
     
     Debug.Log(Gamepad.all[i].name);
}

player = GameObject.Find("Players");

   }






    void FixedUpdate()
    {
        horizontalMove = Input.GetAxisRaw(horizontal) / movementSpeed;
        transform.position += new Vector3(horizontalMove, 0, 0);
    }

    void Update()
    {
        isGrounded = Physics2D.OverlapArea(groundCheckLeft.position, groundCheckRight.position);

        if (Input.GetButtonDown(vertical) && Input.GetAxisRaw(vertical) == 1 && isGrounded)
        {
            rb.AddForce(new Vector2(0f, jumpForce));
        }
 // si le noubre de manette est supèrieur a 0
        if(Gamepad.all.Count > 0){
// si on appuie sur le bouton gauche de la manette
if (Gamepad.all[0].leftStick.left.isPressed){

    player.transform.position += Vector3.left * Time.deltaTime *  5f;
}

        }

    }

    
}
