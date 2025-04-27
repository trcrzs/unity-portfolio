using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //Public Variables
    public float horizontalInput;
    public float speed = 15.0f;
    public float xRange = 12.0f;

    public GameObject projectilePrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Left-Right Input from User
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);

        //Set Player Boundaries
        if (transform.position.x < -xRange)
        {

            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);

        }

        if (transform.position.x > xRange)
        {

            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);

        }

        //Projectile When Player Presses Spacebar
        if (Input.GetKeyDown(KeyCode.Space))
        {

            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);

        }
    }
}
