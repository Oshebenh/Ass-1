using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject pipePairPrefab; 
    public float spawnRate = 1f;
    public float fixedXPosition = 3f; 
    public float minHeightVariation = -0.5f;
    public float maxHeightVariation = 0.5f;  
    public float topPipeYBase = 5.75f; 
    public float bottomPipeYBase = -7f; 

    private void Start()
    {
        InvokeRepeating("SpawnObstacle", 1f, spawnRate); 
    }

    void SpawnObstacle()
    {
      
        float heightVariation = Random.Range(minHeightVariation, maxHeightVariation);
        Vector3 spawnPosition = new Vector3(fixedXPosition, 0, 0); 

        GameObject newPipePair = Instantiate(pipePairPrefab, spawnPosition, Quaternion.identity);

        Transform topPipe = newPipePair.transform.Find("TopPipe");
        Transform bottomPipe = newPipePair.transform.Find("BottomPipe");

        topPipe.localPosition = new Vector3(0, topPipeYBase + heightVariation, 0); 
        bottomPipe.localPosition = new Vector3(0, bottomPipeYBase + heightVariation, 0); 
    }
}


