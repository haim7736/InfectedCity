using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bulletcount : MonoBehaviour
{
    public GameObject Item;
    public int SpawnTime;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawnitem", 5f, SpawnTime);   
    }

    void Spawnitem()
    {
        float randomX = Random.Range(-37f, 37f);
        float randomY = Random.Range(-37f, 37f);
        GameObject item = (GameObject)Instantiate(Item, new Vector3(randomX, randomY, 0f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
