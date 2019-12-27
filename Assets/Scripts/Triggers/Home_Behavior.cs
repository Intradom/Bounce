using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Home_Behavior : MonoBehaviour
{
    [SerializeField] private GameObject ref_GM = null;
    [SerializeField] private string tag_trigger = null;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == tag_trigger)
        {
            ref_GM.GetComponent<Game_Manager>().GameOver();
        }
    }
}
