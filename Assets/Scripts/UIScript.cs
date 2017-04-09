using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour {

    private Text mFuelText;

	// Use this for initialization
	void Start () {
        mFuelText = transform.FindChild("Text").GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        mFuelText.text = "Fuel: " + FuelManager.FuelGet() + "/10";
    }
}
