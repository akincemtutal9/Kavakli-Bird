using UnityEngine;

public class PlayerGravity : MonoBehaviour
{
    [SerializeField] private float gravity;
    void Update()
    {
        transform.Translate(Vector2.down * gravity);
    }
}
