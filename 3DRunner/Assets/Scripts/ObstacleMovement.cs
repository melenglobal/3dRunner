using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    ObstacleSpawner obstacleSpawner;

    private void Awake()
    {
        obstacleSpawner = new ObstacleSpawner();
    }


    void Update()
    {
        transform.position = transform.position + Vector3.back * obstacleSpawner.obstacleSpeed * Time.deltaTime;
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
