using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject[] objectsToSpawn;

    float timeToNextSpawn;
    float timeSinceLastSpawn = 0.0f;

    public float minSpawnTime = 0.5f;
    public float maxSpawnTime = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        // Set the initial random spawn time
        timeToNextSpawn = Random.Range(minSpawnTime, maxSpawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        // Increment the time since the last spawn
        timeSinceLastSpawn += Time.deltaTime;

        // Check if the time since the last spawn has exceeded the time to the next spawn
        if (timeSinceLastSpawn >= timeToNextSpawn)
        {
            // Randomly select an object to spawn
            int selection = Random.Range(0, objectsToSpawn.Length);

            // Instantiate the selected object at the spawner's position
            Instantiate(objectsToSpawn[selection], transform.position, Quaternion.identity);

            // Reset the time for the next spawn and the timer since the last spawn

            timeToNextSpawn = Random.Range(minSpawnTime, maxSpawnTime);
            timeSinceLastSpawn = 0.0f;
        }
    }
}
