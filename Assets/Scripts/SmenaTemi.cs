using UnityEngine;
using UnityEngine.UI;

public class SmenaTemi : MonoBehaviour
{
    int levelUnlock;
    public Button[] buttons;
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

    public void Smena(int ColorIndex)
    {
        PlayerPrefs.SetInt("tema", ColorIndex);

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
}
