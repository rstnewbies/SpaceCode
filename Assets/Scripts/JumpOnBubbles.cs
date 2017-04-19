using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpOnBubbles : MonoBehaviour {

   // public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
    void OnTriggerEnter(Collider other)
    {
        other.SendMessage("Jump", true);
    }
}
