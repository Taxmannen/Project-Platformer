using UnityEngine;

public class SantaAIScript : MonoBehaviour
{
    Vector2 distance;
    public Transform player;
    public Transform weaponHold;
    public GameObject weapon;
    private Vector2 movementDirection;

    void Start()
    {
        weapon.SetActive(false);        
    }

    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.position);
        if (distance < 10f) weapon.SetActive(true);
        else                weapon.SetActive(false);
    }
}
