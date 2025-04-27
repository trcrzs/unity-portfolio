using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float speed = 2.0f;
    public float xRange = 5.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (UnityEngine.GameObject.FindWithTag("Dog") == null)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            }
        }

    }
}
