using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.GetComponent<Text>().text = ""+FuelManager.WorldFuelGet();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
