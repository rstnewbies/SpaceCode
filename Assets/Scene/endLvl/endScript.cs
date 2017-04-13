using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class endScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Text scoreText = transform.FindChild("Score_txt").GetComponent<Text>();
        if (scoreText){
            scoreText.text = FuelManager.FuelGet() + "/10";
        }else{
            Debug.LogError("Score text not found!");
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void retryBtn()
    {
        LevelManager.LevelRetry();
    }

    public void menuBtn()
    {
        SceneManager.LoadScene("menu");
    }

    public void nextBtn()
    {
        LevelManager.LevelRenderNext();
    }
}
