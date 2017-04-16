using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float movementSpeed;
    public float jumpSpeed;
    public float maxAcceleration;
    public bool Grounded = false;
    public float acceleration = 1f;
    private bool moveRight = false;
    private bool moveLeft = false;

    void Start() { }

    void Update() {

        if (moveRight || moveLeft)
        {
            if (acceleration < maxAcceleration)
            {
                acceleration += 0.01f;
            }
        }
        else
        {
            if (acceleration > 0.5f)
            {
                acceleration -= 0.05f;
            }
        }

        if (moveRight)
        {
            float speed = movementSpeed * acceleration;
            GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
        }
        if (moveLeft)
        {
            float speed = -movementSpeed * acceleration;
            GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
        }
    }

    void OnCollisionStay2D(Collision2D Collision)
    {
            Grounded = true;
    }

    void OnCollisionExit2D(Collision2D Collision)
    {
            Grounded = false;
    }

    public void Jump()
    {

        if (Grounded == true)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpSpeed);
            Grounded = false;
        }
    }

    public void MoveLeft()
    {
        moveLeft = true;
    }

    public void MoveRight()
    {
        moveRight = true;
    }

    public void MoveStop()
    {
        moveRight = false;
        moveLeft = false;
    }
}
