using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockRotating : MonoBehaviour
{
    public float speed = 0.0005f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(-speed, 0, 0);
    }
}
