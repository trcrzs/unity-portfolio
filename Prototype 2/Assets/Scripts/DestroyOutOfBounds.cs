using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    //Private Variables
    private float topBound = 30;
    private float lowerBound = -5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Upperbound for projectile
        if (transform.position.z > topBound)
        {

            Destroy(gameObject);

        }

        //Lowerbound for animalPrefabs
        //Ends game if lowerbound is reached
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);

        }

    }
}
