﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour {

    public Text fuelText;

	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {}

    public void MenuBtn()
    {
        SceneManager.LoadScene("menu");
    }
}
