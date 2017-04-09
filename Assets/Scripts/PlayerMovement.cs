using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    void Start() { }

    public bool Grounded = false;

    void OnCollisionStay2D(Collision2D Collision)
    {
        if (Collision.gameObject.tag == "platform")
        {
            Debug.Log("True");
            Grounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D Collision)
    {
        if (Collision.gameObject.tag == "platform")
        {
            Debug.Log("False");
            Grounded = false;
        }
    }

    public void Jump()
    {

        if (Grounded == true)
        {
            this.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 450f));
        }
    }

    public void MoveLeft()
    {
        this.GetComponent<Rigidbody2D>().AddForce(new Vector2(-150f, 0f));
    }

    public void MoveRight()
    {
        this.GetComponent<Rigidbody2D>().AddForce(new Vector2(150f, 0f));
    }
}
