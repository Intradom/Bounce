using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect_Resize : MonoBehaviour
{
    [SerializeField] private float amount_multiply = 1.5f;
    //[SerializeField] private float duration_seconds = 0.5f;

    private Vector3 original_scale;

    private void Start()
    {
        original_scale = this.transform.localScale;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        transform.localScale = original_scale * amount_multiply;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        transform.localScale = original_scale;
    }
}
