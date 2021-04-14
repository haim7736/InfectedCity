using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerDamage : MonoBehaviour
{
    public Slider healthBarSlider;
    public Slider HungerBarSlider;
    public Image gameOverText;
    private bool isGameOver = false;
    public GameObject enemy;
    public float KnockBack;
    public Image bloodscreen;
    Rigidbody2D rb;
    public float time;
    public float HungerGauge;
    public float Damage;
    public float DamageTime;
    // Start is called before the first frame update



    void Start()
    {
        gameOverText.enabled = false;
        rb = GetComponent<Rigidbody2D>();
        isGameOver = true;
        StartCoroutine(Hunger());
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag.Equals("Enemy"))

        {
            int EnemyDamage = other.gameObject.GetComponent<Enemy>().Damage;
            StartCoroutine(ShowBloodScreen());
            healthBarSlider.value -= EnemyDamage;
            //OnDamage();
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (healthBarSlider.value <= 0)
        {
            print("DIE");
            gameOverText.enabled = true;
            Destroy(this.gameObject);
            GameObject[] objects = GameObject.FindGameObjectsWithTag("Enemy");
            for (int i = 0; i < objects.Length; i++)
                Destroy(objects[i]);
        }
    }

    IEnumerator ShowBloodScreen()
    {
        bloodscreen.color = new Color(1, 0, 0, UnityEngine.Random.Range(0.2f, 0.3f));
        yield return new WaitForSeconds(0.1f);
        bloodscreen.color = Color.clear;
    }

    /*void OnDamage()
    {
        if (transform.position.x < enemy.transform.position.x)
        {
            transform.Translate(-KnockBack, 0f, 0f);
        }
        else if (transform.position.x > enemy.transform.position.x)
        {
            transform.Translate(KnockBack, 0f, 0f);
        }
        else if (transform.position.y < enemy.transform.position.y)
        {
            transform.Translate(0f, -KnockBack, 0f);
        }
        else if (transform.position.y > enemy.transform.position.y)
        {
            transform.Translate(0f, KnockBack, 0f);
        }
    }
    */
    IEnumerator Hunger()
    {
        while (true)
        {
            if (HungerBarSlider.value > 0)
            {
                HungerBarSlider.value -= HungerGauge;
                yield return new WaitForSeconds(time);
            }
            else if (HungerBarSlider.value <= 0)
            {
                healthBarSlider.value -= Damage;
                yield return new WaitForSeconds(DamageTime);
            }
        }
    }
}