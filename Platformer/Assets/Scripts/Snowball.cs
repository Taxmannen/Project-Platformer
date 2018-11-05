using UnityEngine;

public class Snowball : MonoBehaviour {
    Rigidbody2D rb;

    PlayerController player;

	void Start ()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();
        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), player.GetComponent<Collider2D>());

        rb = GetComponent<Rigidbody2D>();
        if (player.facingRight) rb.AddForce(new Vector2(3, 3) , ForceMode2D.Impulse);
        else                    rb.AddForce(new Vector2(-3, 3), ForceMode2D.Impulse);
    }
}
