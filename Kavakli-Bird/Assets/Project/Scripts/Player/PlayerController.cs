using UnityEngine;
using Lean.Touch;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float jumpHeight;

    private Rigidbody2D rb2D;

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        LeanTouch.OnFingerDown += HandleFingerDown;
    }

    private void OnDisable()
    {
        LeanTouch.OnFingerDown -= HandleFingerDown;
    }

    private void HandleFingerDown(LeanFinger finger)
    {
        Jump();
    }

    private void Jump()
    {
        SoundManager.Instance.PlayJumpClip();
        rb2D.velocity = Vector2.up * jumpHeight;
    }
}
