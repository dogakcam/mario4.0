using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frogactive : MonoBehaviour
{
    public GameObject frog;
    private void Start()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            frog.SetActive(true);
        }
        if (other.CompareTag("Cap"))
        {
            frog.SetActive(true);
        }
    }
}