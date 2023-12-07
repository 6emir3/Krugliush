using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gotonextlevel : MonoBehaviour
{
    public int ras;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (PlayerPrefs.GetInt("levels")< ras-1)
            PlayerPrefs.SetInt("levels", ras-1);
            SceneManager.LoadScene(1);
        }
    }

    
}
