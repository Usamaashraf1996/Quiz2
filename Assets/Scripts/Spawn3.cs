using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn3: MonoBehaviour
{
    public GameObject enemy3Prefab;
    private Vector3 spawnPos = new Vector3(-21.2f, 0.18f, -13.4f);
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
            Instantiate(enemy3Prefab, spawnPos, enemy3Prefab.transform.rotation);
        }
    }
}
