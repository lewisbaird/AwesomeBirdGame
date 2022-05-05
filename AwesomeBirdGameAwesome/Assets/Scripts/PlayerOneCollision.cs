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

    void OnCollisionEnter(Collision collision)
    {
        PlayerTwoWinsText.gameObject.SetActive(true);
    }
}