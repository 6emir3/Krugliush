using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SmenaTemi2 : MonoBehaviour
{
    // Start is called before the first frame update
    public Image fon;
    void Start()
    {
        if (PlayerPrefs.GetInt("tema") == 0)
            fon.color = new Color32(255, 255, 255, 255);

        if (PlayerPrefs.GetInt("tema") == 1)
            fon.color = new Color32(0, 86, 255, 255);

        if (PlayerPrefs.GetInt("tema") == 2)
            fon.color = new Color32(255, 0, 0, 255);

        if (PlayerPrefs.GetInt("tema") == 3)
            fon.color = new Color32(35, 253, 77, 255);

        if (PlayerPrefs.GetInt("tema") == 4)
            fon.color = new Color32(252, 253, 35, 255);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
