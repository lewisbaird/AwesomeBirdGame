using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerTwoCollision : MonoBehaviour
{
    public TextMeshProUGUI playerOneWinsText;
    //private ShootingScriptPlayer2 playerTwoShootingScript;
    //public bool gameOver;

    void Start()
    {
        //playerTwoShootingScript = GameObject.Find("Player 2 Shooting position").GetComponent<ShootingScriptPlayer2>();
    }

    void Update()
    {
        //if (gameOver == true)
        //{
        //    ShootingScriptPlayer2.PlayerTwoDisable();
        //}
    }

    //when cat hits player one display "Player One Wins" and destroys player two
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("cat"))
        {
            playerOneWinsText.gameObject.SetActive(true);
            Destroy(gameObject);
            //gameOver = true;
        }
    }
}