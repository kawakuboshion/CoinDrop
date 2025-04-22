using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageMove : MonoBehaviour
{
    [SerializeField] private GameObject CoinPerent;
    public float distance = 5f;
    private float theta = 0;
    void Update()
    {
        transform.position = new Vector3(transform.position.x + (Mathf.Sin(theta) * distance), transform.position.y, transform.position.z);
        theta += Time.deltaTime;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Coin")
        {
            other.transform.parent = CoinPerent.transform;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Coin")
        {
            other.transform.parent = null;
        }
    }
}
