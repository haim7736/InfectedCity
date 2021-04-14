using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class MouseCursor : MonoBehaviour
{
    public Texture2D cursorTexture;
    public bool hotSpotIsCenter;
    public Vector2 adjustHotSpot = Vector2.zero;
    private Vector2 hotSpot;
    // Start is called before the first frame update
    public void Start()
    {
        StartCoroutine("MyCursor");
    }

    // Update is called once per frame
    IEnumerator MyCursor()
    {
        yield return new WaitForEndOfFrame();

        if (hotSpotIsCenter)
        {
            hotSpot.x = cursorTexture.width / 2;
            hotSpot.y = cursorTexture.height / 2;
        }
        else
        {
            hotSpot = adjustHotSpot;
        }
        Cursor.SetCursor(cursorTexture, hotSpot, CursorMode.Auto);
    }
    void Update()
    {
        
    }
}
