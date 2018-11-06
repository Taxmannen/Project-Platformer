using UnityEngine;

public class CameraScript : MonoBehaviour {
    public Transform target;
    public float cameraY = 3.5f;

    void FixedUpdate()
    {
        transform.position = new Vector3(target.position.x, cameraY, transform.position.z);
    }
}
