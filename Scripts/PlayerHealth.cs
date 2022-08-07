using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private Rigidbody rb;
    private playercontroller playerScript;

    public int health = 3;
    [SerializeField] Transform spawn_point;

    
    private Transform enemy;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerScript =GetComponent<playercontroller>();

    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        transform.position = spawn_point.position;
        health = 3;
    }
     
     private void Damage()
     {
       playerScript.enabled = false;

      rb.AddForce(Vector3.up * 250);

      if (transform.position.x < enemy.position.x)
          rb.AddForce(Vector3.right * -500);
          else
          rb.AddForce(Vector3.right * 500);

          Invoke("MoveAgain", 1);

     }
     private void MoveAgain()
    {
        playerScript.enabled = true;
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") )
        {
            health--;
            enemy = collision.gameObject.transform;
            Damage();
        }
    }



    
}