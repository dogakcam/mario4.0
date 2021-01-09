using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterpossesion : MonoBehaviour, characterpossesion.IPossessable
{
    
    
    // required by the interface
    void IPossessable.Possess()
    {
        enabled = true; // turning on the component makes Update start ticking
    }
 
    // required by the interface
    void IPossessable.UnPossess()
    {
        enabled = false; // turning off the component makes Update stop ticking
    }
 
    // just some example behavior
    private void Update()
    {
        // follows pointer while the component is enabled
        
       
    }
    public interface IPossessable
    {
        void Possess();
        void UnPossess();
    }
    
}
