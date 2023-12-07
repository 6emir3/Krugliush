using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SmenaMelodii : MonoBehaviour
{
    public GameObject[] MelodiasObject;
    public Button[] MelodiaButton;

    void Start()
    {
        
    }

   
    void Update()
    {
        for (int i = 0; i < MelodiasObject.Length; i++)
        {
            if (i == PlayerPrefs.GetInt("Melodia"))
            {
                MelodiasObject[i].SetActive(true);
                PlayerPrefs.SetInt("Melodia", i);
            }
            else
                MelodiasObject[i].SetActive(false);
        }
    }

    public void Smena(int index)
    {
        PlayerPrefs.SetInt("Melodia", index);
        for (int i = 0; i < MelodiasObject.Length; i++)
        {
            if (i == PlayerPrefs.GetInt("Melodia"))
            {
                MelodiasObject[i].SetActive(true);
                PlayerPrefs.SetInt("Melodia", i);
            }
            else
                MelodiasObject[i].SetActive(false);
        }
            
    }
}
