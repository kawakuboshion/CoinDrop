using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDestroy : MonoBehaviour
{
    void Update()
    {
        if(transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
