using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour {

    private GameObject menuWindow;
    private bool menuShow = false;

	// Use this for initialization
	void Start ()
    {
        menuWindow = GameObject.Find("Menu");
        menuWindow.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {}

    public void ResetLevelBtn()
    {
        LevelManager.LevelRetry();
    }

    public void ExitLevelBtn()
    {
        SceneManager.LoadScene("menu");
    }

    public void MenuBtn()
    {
            menuWindow.SetActive(!menuShow);
            menuShow = !menuShow;  
    }
}
