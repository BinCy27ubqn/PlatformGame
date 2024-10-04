using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marce : MonoBehaviour
{
    public float speed;
    int direction = 1;
    public float distance;
    float startPoint;

    private void Start()
    {
        startPoint = gameObject.transform.position.y;
    }

    void Update()
    {
        transform.Translate(Vector2.up * speed*direction);
        if(transform.position.y - startPoint > distance || transform.position.y < startPoint)
        {
            direction = direction * -1;
        }
    }
}
