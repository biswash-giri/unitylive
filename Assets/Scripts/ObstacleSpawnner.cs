using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawnner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject obstaclePrefab;

    private Rigidbody rb;

    public float timeBetweenWaves = 1f;

    private float timeToSpawn = 2f;

    void Update()
    {
        if (Time.time >= timeToSpawn)
        {
            spawnObstacle();
            timeToSpawn = Time.time + timeBetweenWaves;
        }

    }

    void spawnObstacle()
    {
        int randomFirst = Random.Range(0, spawnPoints.Length);

        int randomSecond = Random.Range(0, 20);

        int spawnIndex = (randomFirst + randomSecond)/2;

        Instantiate(obstaclePrefab, spawnPoints[spawnIndex].position, Quaternion.identity);

    }
}
