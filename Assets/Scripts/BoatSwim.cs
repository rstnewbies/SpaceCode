using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatSwim : MonoBehaviour {

    //public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       
    }

    void OnTriggerStay()
    {
        this.GetComponent<Rigidbody2D>().AddForce(new Vector2(50f, 0f));
    }


}
