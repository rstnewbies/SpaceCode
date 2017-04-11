using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelCollisionScript : MonoBehaviour {

    public Text uiText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            FuelManager.FuelUp();
            UpdateUiText();
        }
    }

    private void UpdateUiText()
    {
        uiText.text = "Fuel: " + FuelManager.FuelGet() + "/10";
    }
}
