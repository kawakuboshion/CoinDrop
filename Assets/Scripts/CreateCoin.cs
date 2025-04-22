using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCoin : MonoBehaviour
{
    [SerializeField] private GameObject Coin;
    public float distance = 5f;
    private float theta = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Create());
    }

    private IEnumerator Create()
    {
        while (true)
        {
            GameObject InsCoin = Instantiate(Coin, new Vector3(transform.position.x + (Mathf.Sin(theta) * distance), 600, 0), Quaternion.identity);
            InsCoin.transform.localScale *= 20;
            InsCoin.transform.Rotate(0, 0, 20);
            theta++;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
