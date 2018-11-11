using UnityEngine;

public class IceBlockScript : MonoBehaviour {

    public GameObject player;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == player)
        {
            transform.Translate(0, 20 * Time.deltaTime, 0);
        }           
    }
}
