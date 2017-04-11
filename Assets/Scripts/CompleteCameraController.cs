using UnityEngine;
using System.Collections;

public class CompleteCameraController : MonoBehaviour
{

    public Transform followObject;     


    private Vector3 offset;         

    // Use this for initialization
    void Start()
    {

    }

    // LateUpdate is called after Update each frame
    void Update()
    {
        transform.position = new Vector3(followObject.position.x, transform.position.y, transform.position.z );
    }
}