using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    StickToEarth stickToEarth;
    MovementX movementX;
    public GameObject[] obstacles;
    public float timerSpawn = 2.5f;
    public float obstacleSpeed = 3f;
    public bool gameOver = false;

    private List<Vector3> listPosition = new List<Vector3>(); //Obstacle spawn position referances.

    private void Awake()
    {
        movementX = new MovementX();
        stickToEarth = new StickToEarth();
    }
    void Start()
    {
        
        float i = -1.6f;
        while (i <= 1.6f)
        {
            Vector3 pos = transform.position + new Vector3(i, 0, 0);
            listPosition.Add(pos);
            i += 0.2f;
            
        }
       
        StartCoroutine(SpawnObstacle());
  

    }

    
    void Update()
    {
        if (gameOver != false)
        {
            StopCoroutine(SpawnObstacle());
        }
    }

    IEnumerator SpawnObstacle()
    {
        yield return new WaitForSeconds(timerSpawn);

        int indexPositionOfObstacle = Random.Range(0, listPosition.Count);
        GameObject currentObstacle = Instantiate(obstacles[Random.Range(0, obstacles.Length)],
            listPosition[indexPositionOfObstacle] + new Vector3(0, 0, 1), Quaternion.identity); 
        

        StartCoroutine(SpawnObstacle());
    }
}
