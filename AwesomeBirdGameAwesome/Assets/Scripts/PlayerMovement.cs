using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float verticalInput;
    public float speed = 10.0f;
    public float yRange = 20;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //keeping the player in bounds
        if (transform.position.y < -yRange)
        {
            transform.position = new Vector3(yRange, transform.position.x, transform.position.z);
        }
        if (transform.position.y > yRange)
        {
            transform.position = new Vector3(-yRange, transform.position.x, transform.position.z);
        }
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * verticalInput * Time.deltaTime * speed);
    }
}
