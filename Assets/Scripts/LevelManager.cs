using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    private static int sCurrentLevel = 0;
    private static string sPathStandart = "lvl_"; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void LevelUp()
    {
        sCurrentLevel++;
    }

    public static void LevelDown()
    {
        sCurrentLevel--;
    }

    public static void LevelReset()
    {
        sCurrentLevel = 1;
    }

    public static void LevelRenderNext()
    {
        LevelUp();
        SceneManager.LoadScene(sPathStandart+sCurrentLevel);
    }

    public static void LevelRenderPrevious()
    {
        LevelDown();
        SceneManager.LoadScene(sPathStandart + sCurrentLevel);
    }

    public static void LevelRender(int lvl)
    {
        SceneManager.LoadScene(sPathStandart + lvl);
    }
}
