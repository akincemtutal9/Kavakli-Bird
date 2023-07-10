using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] private float obstacleMoveSpeed;
    void Update()
    {
        transform.Translate(Vector2.left * obstacleMoveSpeed * Time.deltaTime);

    }
}
