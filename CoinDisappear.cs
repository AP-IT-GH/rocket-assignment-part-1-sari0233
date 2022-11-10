using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDisappear : MonoBehaviour
{
    public void Start()
    {
        
    }

    public void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
