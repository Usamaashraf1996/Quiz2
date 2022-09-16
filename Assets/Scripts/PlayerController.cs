using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody playerRb;
   // public GameObject projectilePrefabs;
    public bool gameOver=false;
    public float xRange = 10f;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();   
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
        Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        float midPoint = (transform.position - Camera.main.transform.position).magnitude * 0.5f;
        transform.LookAt(mouseRay.origin + mouseRay.direction * midPoint);
        //for prjectile launch from player
        //if (Input.GetMouseButtonDown(0))
        //{
        //  //transform.Translate(Vector3.forward * speed * Time.deltaTime);
        //    playerRb.AddForce(Vector3.forward * speed*4, ForceMode.Impulse);
        //     playerRb.AddForce(transform.forward * speed);
        //    Debug.Log("Work");
        //    Instantiate(projectilePrefabs, transform.position, projectilePrefabs.transform.rotation);
        //}
    }
    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Cube1"))
    //    {
    //        gameOver = true;
    //        Destroy(gameObject);
    //    }
    //    else if (collision.gameObject.CompareTag("Cube2")) {
    //        gameOver = true;
    //        Destroy(gameObject);
    //    }
    //}
}
