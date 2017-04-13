using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartGame()
    {
        LevelManager.LevelRender(1);
    }
    public void SelectLvl()
    {
        SceneManager.LoadScene("select");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
