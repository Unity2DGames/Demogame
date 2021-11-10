using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public float moveSpeed = 3;
    public float JumpForce = 5;
    public Rigidbody2D rb;
    public const string RIGHT = "right";
    public const string LEFT = "left";

    string buttonPressed;

    void start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            
            buttonPressed = RIGHT;
            transform.position += transform.right * (Time.deltaTime * 5);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= transform.right * (Time.deltaTime * 5);
            buttonPressed = LEFT;

        }
        else
        {
            buttonPressed = null;
        }
        PlayerJump();
    }
    
    void PlayerJump()
    {
        /*
        if (!Mathf.Approximately(0, moveSpeed))
        {
            transform.rotation = moveSpeed > 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
        }
        */
        if (Input.GetButtonDown("Jump") && Mathf.Abs(rb.velocity.y) < 0.001f)
        {
            rb.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }
    }
    private void FixedUpdate()
    {

        if (buttonPressed == RIGHT)
        {
           
            //We can use >ForceMode2D.Implse for explosion or something instent work it will work too Fast
        }
        else if (buttonPressed == LEFT)
        {
          
        }
        else
        {
          
        }
    }
}


