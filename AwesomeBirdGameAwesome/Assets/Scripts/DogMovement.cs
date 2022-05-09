using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogMovement : MonoBehaviour
{
    public float speed = 4.0f; //the speed the dog travels at

    void Start()
    {

    }

    void Update()
    {
        //moves dog fowards
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
