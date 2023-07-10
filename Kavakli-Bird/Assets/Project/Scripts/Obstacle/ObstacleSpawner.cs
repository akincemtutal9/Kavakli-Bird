using System.Collections;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject obstacle;

    [SerializeField] private Transform spawnPosition;

    [SerializeField] private float spawnTime;

    [SerializeField] private float maxSpawnYposition;

    [SerializeField] private float minSpawnYposition;

    private void Start()
    {
        StartCoroutine(spawnObstacles());     
    }
    private IEnumerator spawnObstacles()
    {
        while (true)
        {
            var x = spawnPosition.position.x;
            var y = spawnPosition.position.y;
            var random = Random.Range(maxSpawnYposition, minSpawnYposition);
            var randomSpawnPosition = new Vector2(x, y + random);

            Instantiate(obstacle, randomSpawnPosition, obstacle.transform.rotation);
            yield return new WaitForSeconds(spawnTime);
        }
    }
}
