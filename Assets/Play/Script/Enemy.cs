using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public Transform target;
    public Vector3 direction;
    public float velocity;
    public float accelaration;
    public GameObject player;


    public float speed;
    public int Damage;
    public int Hp;
    public Image TestImage;
    public Sprite TestSprite;

    // Update is called once per frame
    void Start()
    {
       
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Bullet"))
        {
            int BulletDamage = other.gameObject.GetComponent<BulletMove>().Damage;
            Hp -= BulletDamage;
            GameObject objects = GameObject.FindGameObjectWithTag("Bullet");
            objects.SetActive(false);
        }
    }
    void Update()
    {
        MoveToTarget();
        Vector3 dir = target.position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        if (Hp <= 0)
        {
            Destroy(this.gameObject);
        }


    }
   

    public void MoveToTarget()
    {
        // Player의 현재 위치를 받아오는 Object
        target = GameObject.Find("Player").transform;
        // Player의 위치와 이 객체의 위치를 빼고 단위 벡터화 한다.
        direction = (target.position - transform.position).normalized;
        // 가속도 지정 (추후 힘과 질량, 거리 등 계산해서 수정할 것)
        accelaration = 0.01f;
        // 초가 아닌 한 프레임으로 가속도 계산하여 속도 증가
        velocity = (velocity + accelaration * Time.deltaTime);
        // Player와 객체 간의 거리 계산
        float distance = Vector3.Distance(target.position, transform.position);
        // 일정거리 안에 있을 시, 해당 방향으로 무빙
        if (distance <=9.0f)
        {
            this.transform.position = new Vector3(transform.position.x + (direction.x * speed * Time.deltaTime),
                                                   transform.position.y + (direction.y * speed * Time.deltaTime),
                                                     transform.position.z);
        }
        // 일정거리 밖에 있을 시, 속도 초기화 
        else
        {
            velocity = 0.0f;
        }
    }
    
    
}