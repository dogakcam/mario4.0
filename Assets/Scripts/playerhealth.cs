using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerhealth : MonoBehaviour
{
    public int maxHealth;

    public int currentHealth;
    
    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    
    public void DamagePlayer(int Hurt, Vector3 direction)
    {
        currentHealth -= Hurt;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            gameObject.SetActive(false);
            SceneManager.LoadScene(0);
        }


    }
}
