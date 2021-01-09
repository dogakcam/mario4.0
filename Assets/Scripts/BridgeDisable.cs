using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeDisable : MonoBehaviour
{
    public GameObject Bridge;
    private void Start()
    {
        Bridge.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Bridge.SetActive(true);
        }
        if (other.CompareTag("Cap"))
        {
            Bridge.SetActive(true);
        }
    }
}
