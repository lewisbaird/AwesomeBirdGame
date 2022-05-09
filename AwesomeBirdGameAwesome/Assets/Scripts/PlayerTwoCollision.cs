using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerTwoCollision : MonoBehaviour
{
    public TextMeshProUGUI playerOneWinsText; //The text that says player one wins
    public GameObject playAgainButton; //button to restart the game

    void Start()
    {

    }

    void Update()
    {

    }

    //when cat hits player one display "Player One Wins" and destroys player two and displays restart button
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("cat"))
        {
            playerOneWinsText.gameObject.SetActive(true);
            playAgainButton.gameObject.SetActive(true);
            Destroy(gameObject);
        }
    }
}