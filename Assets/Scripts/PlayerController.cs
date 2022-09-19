using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody playerRb;
   // public GameObject projectilePrefabs;
    public bool gameOver=false;
    public float xRange = 10f;
    public static PlayerController instance;
    public Ray mouseRay;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        playerRb = GetComponent<Rigidbody>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        float midPoint = (transform.position - Camera.main.transform.position).magnitude * 0.5f;
        transform.LookAt(mouseRay.origin + mouseRay.direction * midPoint);
        transform.localRotation = Quaternion.Euler(0, transform.localRotation.y, 0);
        if (Input.GetMouseButtonDown(0)) {
            rb.AddForce(PlayerController.instance.mouseRay.direction, ForceMode.Impulse);
        }
       
    }
   
}
