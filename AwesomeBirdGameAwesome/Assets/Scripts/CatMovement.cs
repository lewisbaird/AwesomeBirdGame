using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMovement : MonoBehaviour
{
    public float speed = 4.0f; //the speed the cat travels at

    void Start()
    {
        
    }

    void Update()
    {
        //moves cat fowards
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

    }
}
