using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float movementSpeed;
    public float jumpSpeed;
    public bool Grounded = false;

    void Start() { }

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
        float speed = -movementSpeed;
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
    }

    public void MoveRight()
    {
        float speed = movementSpeed;
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
    }
}
