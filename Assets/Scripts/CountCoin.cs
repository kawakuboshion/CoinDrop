using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CountCoin : MonoBehaviour
{
    [SerializeField] private GameObject GameOver_Text;
    [SerializeField] private TextMeshProUGUI Coin_Text;
    public static int Coin = 5;
    public bool IsGameOver = false;

    private void Start()
    {
        GameOver_Text.SetActive(false);
        IsGameOver = false;
        StartCoroutine(GameOver());
    }

    private IEnumerator GameOver()
    {
        while (true)
        {
            if (Coin <= 0)
            {
                GameOver_Text.SetActive(true);
                IsGameOver = true;
                yield return new WaitForSeconds(3f);
                Coin = 5;
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
            Coin_Text.text = Coin.ToString();
        }
    }

    public void MinusCoin()
    {
        Coin--;
        Coin_Text.text = Coin.ToString();
    }
}
