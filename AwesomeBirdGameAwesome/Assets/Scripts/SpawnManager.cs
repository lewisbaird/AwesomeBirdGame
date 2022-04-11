using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] ObstaclePrefabs;
    public int ObstacleIndex;
    private float RockXPosition = -35;
    private float RockYPosition = 10;
    private float RockZPosition = 11;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            Instantiate(ObstaclePrefabs[ObstacleIndex], new Vector3(RockXPosition, RockYPosition, RockZPosition), ObstaclePrefabs[ObstacleIndex].transform.rotation);
        }
    }
}
