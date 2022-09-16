using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn2: MonoBehaviour
{
    public GameObject enemy2Prefab;
    private Vector3 spawnPos = new Vector3(-26.1f, 0.14f, 13.3f);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnObstacle()
    {

        if (playerControllerScript.gameOver == false)
        {
            Instantiate(enemy2Prefab, spawnPos, enemy2Prefab.transform.rotation);
        }
    }
}
