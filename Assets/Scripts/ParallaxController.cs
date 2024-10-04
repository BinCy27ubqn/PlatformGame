using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxController : MonoBehaviour
{
    public Transform camera;
    public Transform middleBG;
    public Transform sideBG;
    public Vector3 distanceToSpawn;

    void Update()
    {
        if(camera.position.x > middleBG.position.x)
        {
            sideBG.position = middleBG.position;
            middleBG.position = middleBG.position + distanceToSpawn;
        }
        if (camera.position.x < middleBG.position.x)
        {
            sideBG.position = middleBG.position;
            middleBG.position = middleBG.position - distanceToSpawn;
        }
    }
}
