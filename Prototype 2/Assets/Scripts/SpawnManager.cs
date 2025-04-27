using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    //Variables
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 11;
    private float spawnPosZ = 20;
    private float spawnDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        //To set up random spawning at gamestart
        InvokeRepeating("SpawnRandomAnimal", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomAnimal();
        }

    }

    //Method to spawn animals at random
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
