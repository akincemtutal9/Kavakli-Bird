using System;
using TMPro;
using UnityEngine;

public class PlayerCollectScore : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private int scorePerObstacle;

    private void OnEnable()
    {
        scorePerObstacle = 0;
        scoreText.text = "Score";
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("ScoreBox"))
        {
            scorePerObstacle++;
            scoreText.text = scorePerObstacle.ToString();
            
            Debug.Log(scorePerObstacle);
        }
    }
    public void ResetScore()
    {
        scorePerObstacle = 0;
    }
}
