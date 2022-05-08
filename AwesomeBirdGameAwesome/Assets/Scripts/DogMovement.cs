using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogMovement : MonoBehaviour
{
    public float speed = 4.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //moves dog fowards
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
