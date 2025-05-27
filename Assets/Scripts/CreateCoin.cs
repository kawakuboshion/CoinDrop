using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCoin : MonoBehaviour
{
    [SerializeField] private GameObject coin;
    public float Distance = 5f;
    private float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Create());
    }

    private IEnumerator Create()
    {
        while (true)
        {
            GameObject newCoin = Instantiate(coin, new Vector3(transform.position.x + (Mathf.Sin(time) * Distance), 600, 0), Quaternion.identity);
            newCoin.transform.localScale *= 20;
            newCoin.transform.Rotate(0, 0, 20);
            time++;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
