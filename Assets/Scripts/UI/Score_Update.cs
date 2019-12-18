using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Update : MonoBehaviour
{
    [SerializeField] private string initial_text = "Score: ";

    private Text self_text_ui;
    private int score;

    public void Score_Increment(int amount)
    {
        score += amount;
    }

    private void Awake()
    {
        self_text_ui = this.GetComponent<Text>();
    }

    private void Start()
    {
        score = 0;
    }

    private void Update()
    {
        self_text_ui.text = initial_text + score;
    }
}
