using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float bulletSpeed;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.AddForce(Vector3.right * bulletSpeed);

        
    }
     
     
     private void OnCollisionEnter(Collision collision)
     {
        if(collision.gameObject.CompareTag("Enemy"))
        Destroy(collision.gameObject);
        
     }
      
    // Update is called once per frame
    void Update()
    {
        
    }
}
