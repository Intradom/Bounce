using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game_Manager : MonoBehaviour
{
    [SerializeField] private Text ref_score_text = null;
    [SerializeField] private Text ref_GO_text = null;
    [SerializeField] private Button ref_GO_button = null;

    private bool game_over = false;

    public void UpdateScore(int amount)
    {
        if (!game_over)
        {
            ref_score_text.GetComponent<Score_Update>().Score_Increment(amount);
        }
    }

    public void GameOver()
    {
        ref_GO_text.gameObject.SetActive(true);
        ref_GO_button.gameObject.SetActive(true);

        game_over = true;

        // Show mouse again
        Cursor.visible = true;
    }

    public void RestartGame()
    {
        Debug.Log("Called");

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void Start()
    {
        ref_GO_text.gameObject.SetActive(false);
        ref_GO_button.gameObject.SetActive(false);

        Cursor.visible = false;
    }
}
