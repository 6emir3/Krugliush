using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextMoneta : MonoBehaviour
{
    public static int Coin;
    Text text;
    [SerializeField]
    private GameObject stena;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = Coin.ToString();
        if (text.text == "15")
        {
            Destroy(stena);
            RandomSpawn.spawnRate = 1000f;
            RandomSpawn.nextSpawn = 1000f;
            RandomSpawn.smertspawnRate = 0f;
 
        }
    }
}
