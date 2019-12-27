using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_Behavior : MonoBehaviour
{
    //[SerializeField] private GameObject ref_camera = null;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //ref_camera.GetComponent<Effect_Shake>().Shake();
    }
}
