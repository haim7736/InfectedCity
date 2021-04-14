using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMove : MonoBehaviour
{
    public float speed;

    Rigidbody2D rigd;
    Vector2 direction = Vector2.zero;

    public class example : MonoBehaviour
    {
        public void Awake()
        {
            Screen.fullScreen = !Screen.fullScreen;
        }
    }

    void Start()
    {
        rigd = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {

        if (Input.GetAxisRaw("Vertical") == 0 && Input.GetAxisRaw("Horizontal") == 0)
        {
            rigd.velocity = Vector2.zero;
        }

        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            //transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime, 0f, 0f));
            direction = Vector2.right;
        }
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            //transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime, 0f, 0f));
            direction = Vector2.left;
        }
        if (Input.GetAxisRaw("Vertical") > 0)
        {
            //transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime, 0f, 0f));
            direction = Vector2.up;
        }
        else if (Input.GetAxisRaw("Vertical") < 0)
        {
            //transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime, 0f, 0f));
            direction = Vector2.down;
        }

        rigd.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode2D.Impulse);
    }
}





   

