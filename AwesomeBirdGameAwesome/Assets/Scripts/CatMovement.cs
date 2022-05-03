using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMovement : MonoBehaviour
{
    public float speed = 4.0f;
    //public TextMeshProUGUI PlayerOneWinsText;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerOneWinsText.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        void OnTriggerEnter(Collider other)
        {
            
        }
    }
}
