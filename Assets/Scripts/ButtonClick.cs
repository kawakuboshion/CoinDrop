using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour
{
    public string SceneName;
    public void OnClickLoadScene()
    {
        SceneManager.LoadScene(SceneName);
    }

    public void OnClickNewGame()
    {
        CoinManager.Coin = 5;
    }
}
