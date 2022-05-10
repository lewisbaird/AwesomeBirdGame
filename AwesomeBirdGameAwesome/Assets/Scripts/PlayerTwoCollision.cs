using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerTwoCollision : MonoBehaviour
{
    public TextMeshProUGUI playerOneWinsText; //The text that says player one wins
    public GameObject playAgainButton; //button to restart the game

    private ShootingScriptPlayer2 shootingScriptPlayer2;

    public GameObject player2;

    void Start()
    {
        shootingScriptPlayer2 = player2.GetComponent<ShootingScriptPlayer2>();
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
            shootingScriptPlayer2.DisableScript();
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}