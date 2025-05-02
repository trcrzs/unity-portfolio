using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 10f;
    public float turSpeed = 15.0f;
    public float horizontalInput;
    public float forwardInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * speed * Time.deltaTime * forwardInput);
        transform.Translate(Vector3.left * turnSpeed * Time.deltaTime * horizontalInput);
        
    }
}
