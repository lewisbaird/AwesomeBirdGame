using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    public float verticalInput; //controls for moving player ones shooting position (W and S)
    public float speed = 10.0f; //speed that player ones shooting position moves up and down at
    public float yRangeGoingUp = 13; //point that player ones shooting position gets teleported down at
    public float yRangeGoingDown = 5; //point that player ones shooting position gets teleported up at
    public GameObject projectilePrefab; //where the cat is prefab attatched to

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
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * verticalInput * Time.deltaTime * speed);

        //shooting dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }

    public void DisableScript()
    {
        enabled = false;
    }
}
