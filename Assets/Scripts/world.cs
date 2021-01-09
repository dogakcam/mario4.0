using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Cameras;
/*
public class world : MonoBehaviour
{
    public GameObject[] characters;
    GameObject currentCharacter;
    private int charactersIndex;
    void Start()
    {
        charactersIndex = 0;
        currentCharacter = characters[0];
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            charactersIndex++;
            if (charactersIndex == characters.Length)
            {
                currentCharacter.GetComponent<newthirdperson>().enabled = false;
                characters[charactersIndex].GetComponent<newthirdperson>().enabled = true;
                GameObject.Find("camera").GetComponent<FreeLookCam>().m_Target = characters[charactersIndex].transform;
                currentCharacter = characters[charactersIndex];
                //enable goomba controller
            }
        }
    }
}
*/