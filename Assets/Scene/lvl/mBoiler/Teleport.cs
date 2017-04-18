using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {

    public Transform stage0;
    public Transform stage1;
    public Transform stage2;
    public Transform stage3;
    public Transform stage4;
    public Transform stage5;
    public Transform stage6;
    public int to;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionStay2D(Collision2D Collision)
    {
        if (to == 0)
        {
            to = Random.Range(0, 4);
        }

        switch (to)
        {
            case 0:
                Collision.transform.position = new Vector3(stage0.position.x, stage0.position.y, Collision.transform.position.z);
                break;
            case 1:
                Collision.transform.position = new Vector3(stage1.position.x, stage1.position.y, Collision.transform.position.z);
                break;
            case 2:
                Collision.transform.position = new Vector3(stage2.position.x, stage2.position.y, Collision.transform.position.z);
                break;
            case 3:
                Collision.transform.position = new Vector3(stage3.position.x, stage3.position.y, Collision.transform.position.z);
                break;
            case 4:
                Collision.transform.position = new Vector3(stage4.position.x, stage4.position.y, Collision.transform.position.z);
                break;
            case 5:
                Collision.transform.position = new Vector3(stage5.position.x, stage5.position.y, Collision.transform.position.z);
                break;
            case 6:
                Collision.transform.position = new Vector3(stage6.position.x, stage6.position.y, Collision.transform.position.z);
                break;
        }
    }
}
