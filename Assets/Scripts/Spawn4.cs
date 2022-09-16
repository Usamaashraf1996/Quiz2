using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn4: MonoBehaviour
{
    public GameObject enemy4Prefab;
    private Vector3 spawnPos = new Vector3(19.7f, 0.22f, -13.4f);
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
            Instantiate(enemy4Prefab, spawnPos, enemy4Prefab.transform.rotation);
        }
    }
}
