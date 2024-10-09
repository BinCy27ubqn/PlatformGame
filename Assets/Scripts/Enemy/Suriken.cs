using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suriken : MonoBehaviour
{
    public float force;
    public LayerMask layer;
    public float distance;
    public Animator anim;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * force);

        if (Physics2D.Raycast(gameObject.transform.position, Vector2.left, distance, layer))
        {
            force = 0;
            anim.speed = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            force = 0.011f;
        }
    }
}
