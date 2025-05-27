using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOver_Text;
    [SerializeField] private TextMeshProUGUI coin_Text;
    public static int Coin = 5;
    public bool IsGameOver = false;

    private void Start()
    {
        gameOver_Text.SetActive(false);
        IsGameOver = false;
        StartCoroutine(GameOverMonitoring());
        coin_Text.text = "Coin: " + Coin.ToString();
    }

    private IEnumerator GameOverMonitoring()
    {
        while (true)
        {
            if (Coin <= 0)
            {
                gameOver_Text.SetActive(true);
                IsGameOver = true;
                yield return new WaitForSeconds(3f);
                SceneManager.LoadScene("Title");
            }
            yield return null;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Coin")
        {
            Coin++;
            coin_Text.text = Coin.ToString();
        }
    }

    public void MinusCoin()
    {
        Coin--;
        coin_Text.text = "Coin: " + Coin.ToString();
    }
}
