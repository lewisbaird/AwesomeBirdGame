using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScriptPlayer2 : MonoBehaviour
{
    public float horizontalInput; //controls for moving player twos shooting position (I and K)
    public float speed = 10.0f; //speed that player twos shooting position shooting position moves up and down at
    public float yRangeGoingUp = 14; //point that player twos shooting position gets teleported down at
    public float yRangeGoingDown = 4; //point that player twos shooting position gets teleported up at
    public GameObject projectilePrefab; //where the cat is prefab attatched to
    //public GameObject playerTwoShootingPosition;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
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

        //shoots cats
        if (Input.GetKeyDown(KeyCode.P))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

    }

    //public void PlayerTwoDisable()
    //{ 
    //    enabled = false;
    //    player2TwoShootingPosition.gameObject.SetActive(false);
    //}
}