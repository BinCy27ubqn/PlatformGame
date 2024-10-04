using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetectionCollision : MonoBehaviour
{
    public float spawnTime;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            gameObject.SetActive(false);
            Invoke("Despawn", spawnTime);
        }

        if (collision.gameObject.CompareTag("DeadCheck"))
        {
            PlayerManager.isGameOver = true;
            gameObject.SetActive(false);
        }
    }

    public void Despawn()
    {
        gameObject.transform.position = PlayerManager.checkPointPosition;
        gameObject.SetActive(true);
    }
    

}
