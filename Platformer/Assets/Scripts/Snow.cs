using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snow : MonoBehaviour {
	
	void Update ()
    {
        transform.position = new Vector3(transform.position.x, 12.5f, transform.position.z);	
	}
}
