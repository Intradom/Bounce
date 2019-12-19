﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon_Behavior : MonoBehaviour
{
    [SerializeField] private Camera ref_camera = null;
    [SerializeField] private Rigidbody2D ref_rbody = null;
    [SerializeField] private GameObject ref_pivot_loc = null;
    [SerializeField] private GameObject ref_shoot_loc = null;
    [SerializeField] private GameObject ref_shoot_object = null;
    [SerializeField] private float rot_torque = 1f;
    [SerializeField] private float shot_power = 1f;

    private void Update()
    {
        /* Movement */
        ///*
        Vector3 targ_pos = new Vector3(Input.mousePosition.x, Input.mousePosition.y);
        Vector3 current_pos = ref_camera.WorldToScreenPoint(ref_pivot_loc.transform.position);
        float diff_x = targ_pos.x - current_pos.x;
        float diff_y = targ_pos.y - current_pos.y;

        float angle = -Mathf.Atan2(diff_x, diff_y) * Mathf.Rad2Deg;
        Quaternion target_angle = Quaternion.Euler(new Vector3(0, 0, angle));

        ref_pivot_loc.transform.rotation = Quaternion.RotateTowards(ref_pivot_loc.transform.rotation, target_angle, Mathf.Infinity);
        //*/

        //float mouse_move = -Input.GetAxis("Mouse X");
        //ref_rbody.AddTorque(mouse_move * rot_torque);

        /* Shooting */
        if (Input.GetButtonDown("Shoot"))
        {
            GameObject inst = Instantiate(ref_shoot_object, ref_shoot_loc.transform.position, Quaternion.identity);
            float t_angle = (ref_pivot_loc.transform.rotation.eulerAngles.z + 90) * Mathf.Deg2Rad;
            inst.GetComponent<Rigidbody2D>().AddForce(shot_power * (new Vector2(Mathf.Cos(t_angle), Mathf.Sin(t_angle))));
        }
    }
}
