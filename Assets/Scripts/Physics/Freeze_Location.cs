using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freeze_Location : MonoBehaviour
{
    private Vector3 original_pos;

    private void Start()
    {
        original_pos = this.transform.position;
    }

    private void Update()
    {
        this.transform.position = original_pos;
    }
}