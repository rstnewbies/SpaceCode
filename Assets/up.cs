﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class up : MonoBehaviour {

    public Text ui;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "player")
        {
            Destroy(this.gameObject);
            FuelManager.FuelUp();
        }
    }
}
