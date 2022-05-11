using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerOneCollision : MonoBehaviour
{
    public TextMeshProUGUI playerTwoWinsText; //The text that says player two wins
    public GameObject playAgainButton; //button to restart the game

    private ShootingScript shootingScriptPlayer1;

    public GameObject player1;

    void Start()
    {
        shootingScriptPlayer1 = player1.GetComponent<ShootingScript>();
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
            shootingScriptPlayer1.DisableScript();
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}