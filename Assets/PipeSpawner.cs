using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipes;
    public float spawnInterval = 4.0f;
    public float pipeSpeed = 5.0f; 
    public float minY = 3.5f; 
    public float maxY = 6.5f;
    public float despawnX = -15.0f; 

    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnPipe();
            timer = 0f;
        }
    }

    void SpawnPipe()
    {
        GameObject newPipe = Instantiate(pipes);
        
        float randomY = Random.Range(minY, maxY);
        newPipe.transform.position = new Vector3(transform.position.x, randomY, 0);

        newPipe.AddComponent<PipeMover>().pipeSpeed = pipeSpeed;
        newPipe.GetComponent<PipeMover>().despawnX = despawnX;
    }
}
