using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectLevel : MonoBehaviour {

    public void BtnLvl1()
    {
        LevelManager.LevelRender(1);
    }
    public void BtnLvl2()
    {
        LevelManager.LevelRender(2);
    }
    public void menuBtn()
    {
        SceneManager.LoadScene("menu");
    }
}

