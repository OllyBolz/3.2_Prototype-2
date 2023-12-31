using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private float speed = 10f;
    private float xBounds = 25f;
    private float zBounds = 20f;

    void Update()
    {
        if (transform.position.x < -xBounds || transform.position.x > xBounds || transform.position.z < -zBounds || transform.position.z > zBounds)
        {
            Destroy(gameObject); 
        }

        transform.Translate(Vector3.forward * Time.deltaTime * speed); 
    }
}
