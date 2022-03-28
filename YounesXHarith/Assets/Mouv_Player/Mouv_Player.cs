using UnityEngine;

public class Mouv_Player : MonoBehaviour
{
     public float moveSpeed;

    public bool isJumping = false;

    public Rigidbody2D rb;
    private Vector3 velocity = Vector3.zero;

    void FixUpdate()
    {
        float horizontalmovement = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;

        if(Input.GetButtonDown("Jump"))
        {
            isJumping = true; 
        }


        MovePlayer(horizontalMovement);
    }
   void MovePlayer(float_horizontalMovement)
    {
        Vector3 targerVelocity = new Vector2(_horizontalMovement, rb.velocity.y);
        rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref velocity, .05f);

        if(isJumping==true)
        {
            rb.AddForce(new.Vector2(0f,))
        }
    }



}
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
