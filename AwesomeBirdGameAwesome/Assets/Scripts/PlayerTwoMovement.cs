using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerTwoMovement : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float yRangeGoingUp = 14;
    public float yRangeGoingDown = 4;
    public GameObject projectilePrefab;
    public TextMeshProUGUI PlayerOneWinsText;

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
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.up * horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.P))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

        void OnTriggerEnter(Collider other)
        {
            Debug.Log("collision");
            PlayerOneWinsText.gameObject.SetActive(true);
        }
    }
}
