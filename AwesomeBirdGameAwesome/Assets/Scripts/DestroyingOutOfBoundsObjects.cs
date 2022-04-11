using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyingOutOfBoundsObjects : MonoBehaviour
{
    private float LeftBoundry = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z < LeftBoundry)
        {
            Destroy(gameObject); 
        }
    }
}
