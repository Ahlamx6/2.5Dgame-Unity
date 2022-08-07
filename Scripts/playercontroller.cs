using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
     [SerializeField] private float speed;
      [SerializeField] private float jumpForce;
      [SerializeField] private LayerMask groundLayer;
      [SerializeField] private Transform groundCheck;

        private Rigidbody rb;
        private bool canJump = true;
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

      Vector2 movement = new Vector2(Input.GetAxis("Horizontal") * speed, 0);
        rb.velocity = new Vector2(movement.x, rb.velocity.y);

      bool grounded = Physics.Linecast(transform.position, groundCheck.position, groundLayer);
      Debug.DrawLine(transform.position, groundCheck.position, Color.red);

      if(grounded == true)
      canJump = true;
      else
      canJump = false;
 
       Jump();

    }
        private void Jump()
        {
        if(Input.GetButtonDown("Jump") && canJump == true)
        {
           canJump = false;
           rb.AddForce(Vector3.up * jumpForce);
        }
        }
    }

