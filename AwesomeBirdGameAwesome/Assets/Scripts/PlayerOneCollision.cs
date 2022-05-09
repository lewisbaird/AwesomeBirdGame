using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerOneCollision : MonoBehaviour
{
    public TextMeshProUGUI playerTwoWinsText; //The text that says player two wins
    public GameObject playAgainButton; //button to restart the game

    void Start()
    {

    }

    void Update()
    {

    }

    //when dog hits player one display "Player Two Wins" and destroys player one and displays restart button
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("dog"))
        {
            playerTwoWinsText.gameObject.SetActive(true);
            playAgainButton.gameObject.SetActive(true);
            Destroy(gameObject);
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}