using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerTwoCollision : MonoBehaviour
{
    public TextMeshProUGUI PlayerOneWinsText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        PlayerOneWinsText.gameObject.SetActive(true);
    }
}