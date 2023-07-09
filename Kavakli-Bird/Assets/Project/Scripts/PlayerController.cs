using UnityEngine;
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float jumpHeight;
    public void Jump()
    {
        transform.Translate(Vector2.up * jumpHeight * Time.deltaTime);
    }
}
