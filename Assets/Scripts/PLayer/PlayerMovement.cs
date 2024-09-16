using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public float speed;

    public float xHorizontal;

    public Animator anim;

    public float jumpForce;
    public Transform groundCheck;
    public float groundCheckRadius;
    public bool isGrounded;
    public LayerMask layer;

    public int jumpCount = 0;

    void Update()
    {
        xHorizontal = Input.GetAxis("Horizontal");
        rigidbody2D.velocity = new Vector2(xHorizontal * speed, rigidbody2D.velocity.y);

        Flip();

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, layer);
        anim.SetBool("IsGrounded", isGrounded);
        if (Input.GetKeyDown(KeyCode.W))
        {
            Jump();
        }
    }

    public void Flip()
    {
        if(xHorizontal > 0)
        {
            gameObject.transform.localScale = new Vector3(1, 1, 1);
            anim.SetBool("IsRun", true);
        }
        if(xHorizontal < 0)
        {
            gameObject.transform.localScale = new Vector3(-1, 1, 1);
            anim.SetBool("IsRun", true);
        }

        if(xHorizontal == 0)
        {
            anim.SetBool("IsRun", false);
        }

    }

    public void Jump()
    {
            
        if (isGrounded)
        {
            jumpCount = 0;
            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, jumpForce);
            jumpCount++;
        }
        else
        {
            if (jumpCount == 1)
            {
                rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, jumpForce);
                jumpCount++;
            }
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
    }
}
