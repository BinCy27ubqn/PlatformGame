using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marce : MonoBehaviour
{
    public float speed;
    public int direction = 1;
    public float distance;
    float startPoint;

    public bool isFoward;

    private void Start()
    {
        startPoint = gameObject.transform.position.y;
    }

    void Update()
    {
        transform.Translate(new Vector2(0,1) * speed*direction);
        if (isFoward)
        {
            if (transform.position.y - startPoint > distance || transform.position.y < startPoint)
            {
                direction = direction * -1;
            }
        }

        if(!isFoward)
        {
            if (startPoint - transform.position.y > distance || transform.position.y > startPoint)
            {
                direction = direction * -1;
            }
        }
    }
}
