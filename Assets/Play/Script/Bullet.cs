using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject PlayerMissile;
    public Transform MissileLocation;
    public float FireDelay;
    private bool FireState;
    public int BulletCount = 30;

  
    // Start is called before the first frame update
    void Start()
    {
        FireState = true;
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Food")
        {
            BulletCount += 30;
            Destroy(collision.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (BulletCount >= 0)
        {
            playerFire();

        }
    }

    private void playerFire()
    {
        if (FireState)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                StartCoroutine(FireCycleControl());
                ObjectPool.SpawnPool("Bullet", MissileLocation.position, MissileLocation.rotation);
                BulletCount = BulletCount - 1;
            }
        }
    }


    IEnumerator FireCycleControl()
    {
        FireState = false;
        yield return new WaitForSeconds(FireDelay);
        FireState = true;
    }
}
