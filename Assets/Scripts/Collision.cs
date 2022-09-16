using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.CompareTag("Cube1"))
        {
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("Cube2")) { 
        
        Destroy(collision.gameObject);
        }
    }
}
