using UnityEngine;

public class RotatePropellor : MonoBehaviour
{
    public float turnSpeed = 1000.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(Vector3.forward * turnSpeed * Time.deltaTime);
        
    }
}
