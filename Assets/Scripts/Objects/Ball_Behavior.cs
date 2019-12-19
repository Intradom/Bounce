using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Behavior : MonoBehaviour
{
    [SerializeField] private ParticleSystem ref_particles_collision;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ref_particles_collision.Play();
    }
}
