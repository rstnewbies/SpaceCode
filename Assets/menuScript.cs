﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartGame(string lvl)
    {
        SceneManager.LoadScene(lvl);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
