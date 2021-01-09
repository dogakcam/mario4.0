using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreSystem : MonoBehaviour
{
    public GameObject ScoreText;
    public static int theScore;
    public GameObject MoonText;
    public static int moonScore;
   
    
    void Update()
    {
        ScoreText.GetComponent<Text>().text = " Coin: " + theScore;
        MoonText.GetComponent<Text>().text = " moon: " + moonScore;
    }
}
