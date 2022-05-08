using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyingOutOfBoundsObjectsTwo : MonoBehaviour
{
    private float LeftBoundry = 11;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //destroys cats that leave the scene
        if (transform.position.z > LeftBoundry)
        {
            Destroy(gameObject);
        }
    }
}
