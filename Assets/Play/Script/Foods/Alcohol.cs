using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Alcohol : MonoBehaviour
{
    public Slider HealthBar;
    int Count = 0;
    public GameObject Item;
    public float SpawnTime;
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            InvokeRepeating("Heal", 0f, 1f);
            Invoke("CancelHeal", 5f);
            Destroy(gameObject);
        }
    }

    void Update()
    {
    
    }
    void Heal()
    {
        HealthBar.value += 3;
    }

    void CancelHeal()
    {
        CancelInvoke("Heal");
    }
}