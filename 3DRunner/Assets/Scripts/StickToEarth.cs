using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickToEarth : MonoBehaviour
{
    public int stickerCount;
    ObstacleSpawner obstacleSpawner;

    private void Start()
    {
        obstacleSpawner = new ObstacleSpawner();
    }

    private void OnTriggerEnter(Collider other)    
    {
        if (other.tag == "BadStuff")
        {
            stickerCount++;
            if (stickerCount == 10)
            {
                obstacleSpawner.gameOver = true;
                
                Destroy(this.gameObject);   
            }

            other.enabled = false;
            other.transform.SetParent(this.transform);
            other.GetComponent<ObstacleMovement>().enabled = false;
        }
        if (other.tag == "GoodStuff")
        {   
            Destroy(other.gameObject);
        }
    }
}
