using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemybullet : MonoBehaviour
{
    [SerializeField] private float bulletSpeed;
    [SerializeField] private float bulletLifeSpan;
    private Rigidbody rb;
    private PlayerHealth PlayerHealthScript;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * bulletSpeed);
        Invoke("Delete", bulletLifeSpan);  
    }
     
     private void Delete()
     {
        Destroy(gameObject);
     }
     private void OnCollisionEnter(Collision collision)
     {
        if(collision.gameObject.CompareTag("Player"))
        {
        PlayerHealthScript = collision.gameObject.GetComponent<PlayerHealth>();
        PlayerHealthScript.health--;

        Destroy(collision.gameObject);
        }
     }

    // Update is called once per frame
    void Update()
    {
        
    }
}
