using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyingOutOfBoundsObjectsTwo : MonoBehaviour
{
    private float rightBoundry = 11; //distance cat has to travel to to get deleted

    void Start()
    {

    }

    void Update()
    {
        //destroys cats that leave the scene
        if (transform.position.z > rightBoundry)
        {
            Destroy(gameObject);
        }
    }
}
