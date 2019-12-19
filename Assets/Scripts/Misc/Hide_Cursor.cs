using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide_Cursor : MonoBehaviour
{
    [SerializeField] private bool locked = false;

    private void Start()
    {
        if (locked)
        {
            Cursor.lockState = CursorLockMode.Locked; // This will keep cursor in center
        }
        else
        {
            Cursor.visible = false;
        }
    }
}
