using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SmenaSkina : MonoBehaviour
{
    public void Update()
    {
        int SkinIndex = PlayerPrefs.GetInt("skin");
        if (SkinIndex == 10)
        {
            o.SetActive(true);
            o1.SetActive(false);
        }

        PlayerPrefs.SetInt("skin", SkinIndex);
        if (SkinIndex == 20)
        {
            o1.SetActive(true);
            o.SetActive(false);
        }
    }

    public Button[] buttons;

    [SerializeField]
    GameObject o;
    [SerializeField]
    GameObject o1;

    public void Smena(int SkinIndex)
    {
        PlayerPrefs.SetInt("skin", SkinIndex);
        if (SkinIndex == 10)
        {
            o.SetActive(true);
            o1.SetActive(false);
        }

        PlayerPrefs.SetInt("skin", SkinIndex);
        if (SkinIndex == 20)
        {
            o1.SetActive(true);
            o.SetActive(false);
        }



    }
}
