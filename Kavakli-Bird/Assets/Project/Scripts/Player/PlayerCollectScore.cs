using UnityEngine;

public class PlayerCollectScore : MonoBehaviour
{
    [SerializeField] private int scorePerObstacle;

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("ScoreBox"))
        {
            scorePerObstacle++;
            Debug.Log(scorePerObstacle);
        }
    }
}
