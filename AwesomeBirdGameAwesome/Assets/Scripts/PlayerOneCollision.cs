using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerOneCollision : MonoBehaviour
{
    public TextMeshProUGUI PlayerTwoWinsText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //when dog hits player one display "Player Two Wins" and destroys player one
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("dog"))
        {
            PlayerTwoWinsText.gameObject.SetActive(true);
            Destroy(gameObject);
        }
    }
}