using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterController2D : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 50f;
    private int jumpForce = 320;
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

player = GameObject.Find("Player 1");
//player2 = GameObject.Find("Player 2");
//player3 = GameObject.Find("Player 3");
//player3 = GameObject.Find("Player 4");

   }



    void FixedUpdate()
    {
        // aller a gauche
        if (Gamepad.all[0].leftStick.left.isPressed){

    player.transform.position += Vector3.left * Time.deltaTime *  2f;
    }

   /*     if (Gamepad.all[1].leftStick.left.isPressed){

    player2.transform.position += Vector3.left * Time.deltaTime *  2f;
    }

*/

/*
    if (Gamepad.all[2].leftStick.left.isPressed){

    player3.transform.position += Vector3.left * Time.deltaTime *  2f;
    }

*/


/*
       if (Gamepad.all[3].leftStick.left.isPressed){

    player4.transform.position += Vector3.left * Time.deltaTime *  2f;
    }

*/


else{
horizontalMove = Input.GetAxisRaw(horizontal) / movementSpeed;
        transform.position += new Vector3(horizontalMove, 0, 0);
}










// aller a droite
if (Gamepad.all[0].leftStick.right.isPressed){

    player.transform.position += Vector3.right * Time.deltaTime *  2f;
}

/*
if (Gamepad.all[1].leftStick.right.isPressed){

    player1.transform.position += Vector3.right * Time.deltaTime *  2f;
}

if (Gamepad.all[2].leftStick.right.isPressed){

    player2.transform.position += Vector3.right * Time.deltaTime *  2f;
}

if (Gamepad.all[3].leftStick.right.isPressed){

    player3.transform.position += Vector3.right * Time.deltaTime *  2f;
}

*/


// aller en haut 

if (Gamepad.all[0].leftStick.up.isPressed){

    player.transform.position += Vector3.up * Time.deltaTime * 3f;
}

/*
if (Gamepad.all[1].leftStick.up.isPressed){

    player1.transform.position += Vector3.up * Time.deltaTime * 2f;
}

if (Gamepad.all[2].leftStick.up.isPressed){

    player2.transform.position += Vector3.up * Time.deltaTime * 2f;
}

if (Gamepad.all[3].leftStick.up.isPressed){

    player3.transform.position += Vector3.up * Time.deltaTime * 2f;
}

*/



        
    }

    void Update()
    {
        isGrounded = Physics2D.OverlapArea(groundCheckLeft.position, groundCheckRight.position);

        if (Input.GetButtonDown(vertical) && Input.GetAxisRaw(vertical) == 1 && isGrounded)
        {
            rb.AddForce(new Vector2(0f, jumpForce));
        }

    }

    
}
