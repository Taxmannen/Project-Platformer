using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCameraController : MonoBehaviour {

    public Transform[] mounts;
    public float transitionSpeed;
    Transform currentMount;


	void Start () {
		
	}

    private void Update()
    {
        if (currentMount != null) transform.position = Vector3.Lerp(transform.position, currentMount.position, Time.deltaTime * transitionSpeed);
    }

    public void SetCameraMount(Transform newMount)
    {
        currentMount = newMount;
    }
}
