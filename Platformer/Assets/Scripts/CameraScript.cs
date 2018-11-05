using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {


    public Transform target;
    public float cameraY = 3.5f;
    //public float cameraY;

    void Awake()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(target.position.x, cameraY, transform.position.z);

    }
}
