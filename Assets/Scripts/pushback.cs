using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushback : MonoBehaviour
{

    public float force = 1;    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy"  )
        {
            Vector3 pushDirection = other.transform.position - transform.position;
            pushDirection = -pushDirection.normalized;
            GetComponent<Rigidbody>().AddForce(pushDirection*force*100);


        }
    }
}
