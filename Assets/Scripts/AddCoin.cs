using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCoin : MonoBehaviour
{
    [SerializeField] private GameObject Coin;
    [SerializeField] private CountCoin CountCoin;
    public Vector3 CreatePosition;
    public float distance = 0.005f;
    private float theta = 0;
    void Update()
    {
        CreatePosition.z += Mathf.Sin(theta) * distance;
        if(Input.GetKeyDown(KeyCode.Space) && CountCoin.Coin > 0 && !CountCoin.IsGameOver)
        {
            Instantiate(Coin, CreatePosition, Quaternion.identity);
            CountCoin.MinusCoin();
            Debug.Log(CreatePosition);
        }
        theta += Time.deltaTime;
    }
}
