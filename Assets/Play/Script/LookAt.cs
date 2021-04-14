using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    private GameObject hero;
    private Vector3 resultPoint;
    private Quaternion mQut;
    /*
    private void Awake()
    {
        InitObject();
        StartCoroutine(UpdateTouch());
    }

    private void InitObject()
    {
        hero = GameObject.Find("Player");
    }
    private IEnumerator UpdateTouch()
    {
        while(true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                resultPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition) - hero.transform.position;
                Vector2 offset = new Vector2(resultPoint.x, resultPoint.y);
                float mangle = Mathf.Atan2(offset.y, offset.x) * Mathf.Rad2Deg;
                mQut = Quaternion.Euler(new Vector3(0, 0, mangle));
            }
            hero.transform.rotation = Quaternion.Slerp(hero.transform.rotation, mQut, 0.1f);
            yield return null;
        }
    }
    */
    void Start()
        {
     
        }

        // Update is called once per frame
        void Update()
       {
        Vector3 mPosition = Input.mousePosition; //마우스 좌표 저장
        Vector3 oPosition = transform.position; //게임 오브젝트 좌표 저장

        mPosition.z = oPosition.z - Camera.main.transform.position.z;

        Vector3 target = Camera.main.ScreenToWorldPoint(mPosition);

        float dy = target.y - oPosition.y;
        float dx = target.x - oPosition.x;

   
        float rotateDegree = Mathf.Atan2(dy, dx) * Mathf.Rad2Deg - 90;

        transform.rotation = Quaternion.Euler(0f, 0f, rotateDegree);


    
       }
}

