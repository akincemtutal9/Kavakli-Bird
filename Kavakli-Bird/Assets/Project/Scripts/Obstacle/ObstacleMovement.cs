using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] private float obstacleMoveSpeed;
    void LateUpdate()
    {
        transform.Translate(Vector2.left * obstacleMoveSpeed * Time.deltaTime);

    }
}
