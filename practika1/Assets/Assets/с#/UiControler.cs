using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiControler : MonoBehaviour
{
    public Texture2D PointerEnterState;
    public Texture2D PointerExitState;
    public Texture2D MouseButton;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor(PointerExitState, Vector2.zero, CursorMode.Auto);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Cursor.SetCursor(MouseButton, Vector2.zero, CursorMode.Auto);
        }
        else if (Input.GetMouseButton(0)) 
        {
            Cursor.SetCursor(PointerExitState, Vector2.zero, CursorMode .Auto);
        }
    }
}
