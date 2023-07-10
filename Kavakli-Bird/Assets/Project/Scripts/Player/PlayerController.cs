using UnityEngine;
using Lean.Touch;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float jumpHeight;

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
       transform.Translate(Vector3.up * jumpHeight); 
    }
}
