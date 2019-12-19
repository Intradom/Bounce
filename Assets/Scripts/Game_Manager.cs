using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Manager : MonoBehaviour
{
    [SerializeField] private Text ref_score_text;

    public void UpdateScore(int amount)
    {
        ref_score_text.GetComponent<Score_Update>().Score_Increment(amount);
    }
}
