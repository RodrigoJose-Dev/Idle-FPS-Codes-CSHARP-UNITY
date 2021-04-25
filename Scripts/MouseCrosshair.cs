using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCrosshair : MonoBehaviour
{

    private void Start()
    {
        Cursor.visible = false;
    }

    private void Update()
    {
        //cursorPos recebe a posição do mouse e dps passa pro transform.position dele
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = cursorPos;

    }

}
