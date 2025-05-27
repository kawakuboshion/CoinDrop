using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageMove : MonoBehaviour
{
    [SerializeField] private GameObject coinParent;
    public float Distance = 5f;
    private float time = 0;
    void Update()
    {
        transform.position = new Vector3(transform.position.x + (Mathf.Sin(time) * Distance), transform.position.y, transform.position.z);
        time += Time.deltaTime;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Coin")
        {
            other.transform.parent = coinParent.transform;
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
