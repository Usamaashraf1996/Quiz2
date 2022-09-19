using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 20.0f;

    public GameObject projectilePrefab;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = projectilePrefab.GetComponent<Rigidbody>();
        Instantiate(projectilePrefab, transform.position, transform.rotation);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Launch a projectile
            rb.AddForce(PlayerController.instance.mouseRay.direction, ForceMode.Impulse);
          
        }
    }
}
