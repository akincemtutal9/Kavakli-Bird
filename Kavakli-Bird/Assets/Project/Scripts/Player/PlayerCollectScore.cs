using TMPro;
using UnityEngine;

public class PlayerCollectScore : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private int scorePerObstacle;

    private void OnEnable()
    {
        ResetScore();
        scoreText.text = "Score";
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("ScoreBox"))
        {
            scorePerObstacle++;
            scoreText.text = scorePerObstacle.ToString();
            SoundManager.Instance.PlayBlockPassClip();
            Debug.Log(scorePerObstacle);
        }
    }

    private void ResetScore()
    {
        scorePerObstacle = 0;
    }
}
