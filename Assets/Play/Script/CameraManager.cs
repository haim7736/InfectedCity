using UnityEngine;
using System.Collections;

public class CameraManager : MonoBehaviour
{
    public GameObject A;
    Transform AT;

    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    void Start()
    {
        AT = A.transform;
      
    }
    void FixedUpdate()
    {
     
        if (A.activeSelf)
        {
            transform.position = Vector3.Lerp(transform.position, AT.position, 3f * Time.deltaTime);
            transform.Translate(0, 0, -10); //카메라를 원래 z축으로 이동
        }
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, minX, maxX), Mathf.Clamp(transform.position.y, minY, maxY), transform.position.z);
    }
}
