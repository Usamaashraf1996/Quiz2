using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 10.0f;

    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      
        transform.Translate(Vector3.forward  * speed * Time.deltaTime);
        if (Input.GetMouseButtonDown(0))
        {
            //Launch a projectile
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
           // transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
}
