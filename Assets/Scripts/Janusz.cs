using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Janusz : MonoBehaviour {

    public static int currentLvl;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void tankuj()
    {
        SceneManager.LoadScene("lvl_"+(currentLvl+1));
        currentLvl++;
    }
}
