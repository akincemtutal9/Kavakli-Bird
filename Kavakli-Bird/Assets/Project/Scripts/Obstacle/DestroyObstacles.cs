using UnityEngine;

public class DestroyObstacles : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("GameBox"))
        {
            Destroy(gameObject);
        }
    }
}
