using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoMovement : MonoBehaviour
{
    public float horizontalInput; //controls for moving player two (I and K)
    public float speed = 10.0f; //speed that player two moves up and down at
    public float yRangeGoingUp = 14; //The height at which player two is teleported back down
    public float yRangeGoingDown = 4; //The height at which player two is teleported back up

    void Start()
    {

    }

    void Update()
    {
        //keeping the player in bounds
        if (transform.position.y < yRangeGoingDown)
        {
            transform.position = new Vector3(transform.position.x, yRangeGoingUp, transform.position.z);
        }
        if (transform.position.y > yRangeGoingUp)
        {
            transform.position = new Vector3(transform.position.x, yRangeGoingDown, transform.position.z);
        }

        //movement controls
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.up * horizontalInput * Time.deltaTime * speed);
    }
}
