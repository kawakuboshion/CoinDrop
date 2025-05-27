using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCoin : MonoBehaviour
{
    [SerializeField] private GameObject coin;
    [SerializeField] private CoinManager coinManager;
    public Vector3 CreatePosition;
    public float Distance = 0.005f;
    private float time = 0;
    void Update()
    {
        CreatePosition.z += Mathf.Sin(time) * Distance;
        if(Input.GetKeyDown(KeyCode.Space) && CoinManager.Coin > 0 && !coinManager.IsGameOver)
        {
            Instantiate(coin, CreatePosition, Quaternion.identity);
            coinManager.MinusCoin();
            Debug.Log(CreatePosition);
        }
        time += Time.deltaTime;
    }
}
