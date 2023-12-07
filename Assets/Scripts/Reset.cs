using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    
    public void restart()
    {
        int activeScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(activeScene);
    }

    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.R)) && (Time.timeScale == 1))
        {
            int activeScene = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(activeScene);
        }
    }
}
