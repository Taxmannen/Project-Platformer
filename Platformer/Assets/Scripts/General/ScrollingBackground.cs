using UnityEngine;

public class ScrollingBackground : MonoBehaviour {
    [Range(0.1f, 1f)]
    public float scrollSpeed;

    Renderer rend;
    Transform cam;
    float offset;

    void Start()
    {
        rend = GetComponent<Renderer>();
        cam = GameObject.Find("Main Camera").transform;
    }

    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0) offset += (scrollSpeed/100);
        if (Input.GetAxisRaw("Horizontal") < 0) offset -= (scrollSpeed/100);

        rend.material.mainTextureOffset = new Vector2(offset, 0);
        transform.position = new Vector3(cam.position.x, transform.position.y, 0);
    }
}
