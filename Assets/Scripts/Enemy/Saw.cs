using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saw : MonoBehaviour
{

    public float rotationSpeed;
    public float speed;
    public Transform sawCheck;

    bool isGroundCheck;
    public Transform pointRay;
    public float distanceRayCheck;
    public LayerMask layer;

    int direction = 1;
    Vector2 rayDirection = new Vector3(1, -1);

    void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed);
        
        isGroundCheck = Physics2D.Raycast(pointRay.position, rayDirection, distanceRayCheck,layer);
        if (isGroundCheck)
        {
            sawCheck.Translate(Vector2.right * speed* direction);
        }
        if (!isGroundCheck)
        {
            direction = direction * -1;
            rayDirection.x = rayDirection.x * -1;
            sawCheck.Translate(Vector2.right * speed * direction);

            Vector3 iTemp = sawCheck.localScale;
            iTemp.x *= -1;
            sawCheck.localScale = iTemp;
        }

        Debug.DrawRay(pointRay.position, rayDirection * distanceRayCheck, Color.red);

    }
}
