using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerManager : MonoBehaviour
{
    public static bool isGameOver;
    public GameObject gameOverSence;

    public static Vector3 checkPointPosition = new Vector3(-7.14f,0.21f,0);
    public GameObject player;

    public TextMeshProUGUI textCoin;

    private void Awake()
    {
        isGameOver = false;
    }

    void Update()
    {
        textCoin.text = CurrencyManager.Instance.totalCoins.ToString();

        if (isGameOver)
        {
            gameOverSence.SetActive(true);
        }
    }

    public void IsReloadLevel(int level)
    {
        SceneManager.LoadScene(level);
    }
}
