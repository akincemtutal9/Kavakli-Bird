using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class PlayerDie : MonoBehaviour
{
    private bool isDead = false;
    public bool IsDead => isDead;
    public UnityEvent OnDie;
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
            OnDie?.Invoke();
            GameStates.Instance.ChangeGameState(GameStates.GameState.Die);
            //            StartCoroutine(WaitForChangeState());
        }
    }
}
