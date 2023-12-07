using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject obj;
    float RandX;
    Vector2 whereToSpawn;
    [SerializeField]
    public static float spawnRate = 0.3f;
    [SerializeField]
    public static float nextSpawn = 0.3f;

    [SerializeField]
    private GameObject smertobj;
    float smertRandX;
    Vector2 smertwhereToSpawn;
    [SerializeField]
    public static float smertspawnRate = 6f;
    [SerializeField]
    public static float smertnextSpawn = 1f;

    void Start()
    {
        TextMoneta.Coin = 0;
         spawnRate =0.2f;
        nextSpawn = 2f;
        smertspawnRate = 1f;
        smertnextSpawn = 3f;
    }

    void Update()
    {
        if (Time.time > nextSpawn)
        { 
            nextSpawn = Time.time + spawnRate;
            RandX = Random.Range(-14.82f, 9.29f);
            whereToSpawn = new Vector2(RandX, transform.position.y);
            Instantiate(obj, whereToSpawn, Quaternion.identity);
        }

        if (Time.time > smertnextSpawn)
        {
            smertnextSpawn = Time.time + smertspawnRate;
            smertRandX = Random.Range(-14.82f, 9.29f);
            smertwhereToSpawn = new Vector2(smertRandX, transform.position.y);
            Instantiate(smertobj, smertwhereToSpawn, Quaternion.identity);
        }
    }
}
