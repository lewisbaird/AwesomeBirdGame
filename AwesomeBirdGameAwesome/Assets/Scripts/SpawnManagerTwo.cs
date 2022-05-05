using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerTwo : MonoBehaviour
{
    public GameObject[] ObstaclePrefabs;
    private float RockXPosition = 50;
    private float RockZPosition = -4;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(ObstaclePrefabs[0], new Vector3(RockXPosition, Random.Range(13, 5), RockZPosition), ObstaclePrefabs[0].transform.rotation);
        }
    }
}

