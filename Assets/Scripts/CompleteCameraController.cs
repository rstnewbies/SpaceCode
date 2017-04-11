using UnityEngine;
using System.Collections;

public class CompleteCameraController : MonoBehaviour
{

    public Transform player;     


    private Vector3 offset;         

    // Use this for initialization
    void Start()
    {

    }

    // LateUpdate is called after Update each frame
    void Update()
    {
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z );
    }
}