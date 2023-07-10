using UnityEngine;

public class PlayerDie : MonoBehaviour
{
    private bool isDead = false;

    private void Start()
    {
        isDead = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            isDead = true;
            Debug.Log("öldü");
            // gameStatei Die yap;
        }
    }

}
