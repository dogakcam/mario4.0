using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moon : MonoBehaviour
{
    public int moon= 0;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("moon")) 
        {
            moon += 1;
            Debug.Log("Something Touched me");
            ScoreSystem.moonScore = moon;

            Destroy(other.gameObject); 

        }
    }
}
