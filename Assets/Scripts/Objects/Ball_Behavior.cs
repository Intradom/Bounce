using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Behavior : MonoBehaviour
{
    [SerializeField] private ParticleSystem ref_particles_collision = null;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ref_particles_collision.Play();
    }

    private void OnBecameInvisible()
    {
        // If ball leaves screen, destroy
        Destroy(this.gameObject);
    }
}
