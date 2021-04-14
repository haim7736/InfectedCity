using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySp : MonoBehaviour
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
}
