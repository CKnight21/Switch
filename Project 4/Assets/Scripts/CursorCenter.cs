using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorCenter : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Cursor.lockState = CursorLockMode.None;
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;

        }
    }
}
