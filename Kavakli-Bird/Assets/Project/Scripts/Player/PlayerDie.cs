using System.Collections;
using UnityEngine;
public class PlayerDie : MonoBehaviour
{
    private bool isDead = false;
    public bool IsDead => isDead;
    private void OnEnable()
    {
        isDead = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle") && !isDead)
        {
            isDead = true;
            Debug.Log("öldü");
            SoundManager.Instance.PlayDieClip();
            StartCoroutine(WaitForChangeState());
        }
    }

    private IEnumerator WaitForChangeState()
    {
        yield return new WaitForSeconds(2f);
        GameStates.Instance.ChangeGameState(GameStates.GameState.Die);
    }
}
