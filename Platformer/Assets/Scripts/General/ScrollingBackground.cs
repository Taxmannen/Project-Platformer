using UnityEngine;

public class ScrollingBackground : MonoBehaviour {
    [Range(0.1f, 1f)]
    public float scrollSpeed;

    Renderer rend;
    Transform cam;
    Transform player;
    float offset;
    float oldX;

    void Start()
    {
        rend = GetComponent<Renderer>();
        cam = GameObject.Find("Main Camera").transform;
        player = GameObject.Find("Player").transform;
    }

    void FixedUpdate()
    {
        if (player.transform.position.x.ToString("F1") != oldX.ToString("F1"))
        {
            if (Input.GetAxisRaw("Horizontal") > 0) offset += (scrollSpeed / 100);
            if (Input.GetAxisRaw("Horizontal") < 0) offset -= (scrollSpeed / 100);

            rend.material.mainTextureOffset = new Vector2(offset, 0);
            oldX = player.transform.position.x;
        }
        transform.position = new Vector3(cam.position.x, transform.position.y, 0);
    }
}
