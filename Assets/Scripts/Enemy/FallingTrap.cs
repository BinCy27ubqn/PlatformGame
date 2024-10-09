using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingTrap : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public LayerMask layerMask;
    public float distance;

    void Update()
    {
        if (Physics2D.Raycast(gameObject.transform.position, Vector2.down, distance, layerMask))
        {
            rigidbody2D.isKinematic = false;
            gameObject.tag = "Enemy";
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            rigidbody2D.isKinematic = true;
            gameObject.layer = 3;
            gameObject.tag = "Untagged";
        }
    }

    private void OnDrawGizmos()
    {
        Debug.DrawRay(gameObject.transform.position, Vector2.down * distance, Color.white);
    }
}
