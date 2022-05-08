using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundRotating : MonoBehaviour
{
    public float speed = 0.0005f;

    void Start()
    {

    }

    // Background rotates left
    void Update()
    {
        transform.Rotate(0, -speed, 0);
    }
}
