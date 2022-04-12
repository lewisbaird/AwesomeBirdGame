using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] ObstaclePrefabs;
    private float RockXPosition = -35;
    private float RockZPosition = 11;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            Instantiate(ObstaclePrefabs[0], new Vector3(RockXPosition, Random.Range(13, 5), RockZPosition), ObstaclePrefabs[0].transform.rotation);
        }
    }
}

