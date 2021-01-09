using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smacked : MonoBehaviour


{

    // also create var for animation

    private void OnTriggerEnter(Collider collision)
        {
            Debug.Log("something touched me");
            if (collision.gameObject.tag == "Player")
            {
                Debug.Log("Player touched");
                foreach (Transform child in transform)
                    child.gameObject.SetActive(false);
                //GetComponent<Animation>().Play; for animation
                //gameObject.GetComponent<Animation>().Play;
    
                Destroy(transform.parent.gameObject);
            }
        }
       
}
