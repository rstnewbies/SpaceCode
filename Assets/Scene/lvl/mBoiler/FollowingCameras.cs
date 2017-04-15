using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingCameras : MonoBehaviour {

    public Transform followObject;

    private Vector3 offset;

    // Use this for initialization
    void Start()
    {

    }

    // LateUpdate is called after Update each frame
    void Update()
    {
        transform.position = new Vector3(followObject.position.x, followObject.position.y, transform.position.z);
    }
}
