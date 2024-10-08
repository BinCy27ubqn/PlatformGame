using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            
            CurrencyManager.Instance.totalCoins++;
            PlayerPrefs.SetInt("Money", CurrencyManager.Instance.totalCoins);
        }
    }
}
