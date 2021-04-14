using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float MoveSpeed;
    float timeSpan;
    float checkTime;
    public int Damage;
    // Start is called before the first frame upda
    void Start()
    {
        timeSpan = 0.0f;
        checkTime = 1f;
    }
    
 

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * MoveSpeed * Time.deltaTime);
        timeSpan += Time.deltaTime;
        if(timeSpan > checkTime)
        {
            gameObject.SetActive(false);
            timeSpan = 0;
        }
    }
}
