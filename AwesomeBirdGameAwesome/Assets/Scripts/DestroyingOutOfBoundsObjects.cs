using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyingOutOfBoundsObjects : MonoBehaviour
{
    private float leftBoundry = -10; //distance dog has to travel to to get deleted

    void Start()
    {
        
    }

    void Update()
    {
        //destroys dogs that leave the scene
        if(transform.position.z < leftBoundry)
        {
            Destroy(gameObject); 
        }
    }
}
